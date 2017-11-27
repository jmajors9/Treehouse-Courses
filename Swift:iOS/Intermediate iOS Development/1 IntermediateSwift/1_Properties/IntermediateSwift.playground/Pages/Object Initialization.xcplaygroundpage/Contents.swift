// Object Initialization



enum Day: Int {
    case sunday = 1
    case monday
    case tuesday
    case wednesday
    case thursday
    case friday
    case saturday
}

let day = Day(rawValue: 8)


// init? () {}
/*
class Person {
    let name: String
    let age: Int
    
    init?(dict: [String: AnyObject]) {
        guard let name = dict["name"] as? String, let age = dict["age"] as? Int else {
            return nil
        }
        
        self.name = name
        self.age = age
    }
    
}

*/

//init()  throws{}
enum PersonError: Error {
    case invalidData
}

class Person {
    let name: String
    let age: Int
    
    init(dict: [String: AnyObject]) throws {
        guard let name = dict["name"] as? String, let age = dict["age"] as? Int else {
            throw PersonError.invalidData
        }
        
        self.name = name
        self.age = age
    }
    
}

// Initializer Delegation - Value Types

struct Point {
    var x: Int = 0
    var y: Int = 0
}

struct Size {
    var width: Int = 0
    var height: Int = 0
}

struct Rectangle {
    var origin = Point()
    var size = Size()
    
    init(origin: Point, size: Size) {
        self.origin = origin
        self.size = size
    }
    
    init(x: Int, y: Int, height: Int, width: Int) {
        let origin = Point(x: x, y: y)
        let size = Size(width: width, height: height)
        
        // self.origin = origin
        // self.size = size
        // above commented out because it's already in the earlier init
        
        self.init(origin: origin, size: size)
    }
    
    init(center: Point, size: Size){
        let originX = center.x - size.width/2
        let originY = center.y - size.height/2
        let origin = Point(x: originX, y: originY)
        
        self.init(origin: origin, size: size)
    }
    
}


// Initializer Delegation - Reference Types
// designated - primary, calls super init


class Vehicle {
    let name: String
    
    init(name: String) {
        self.name = name
    }
    // convenience initializer can only call a designated init in the same class
    
    convenience init() {
        self.init(name: "Unnamed")
    }
    
}

Vehicle()

// Initializer Delegation - Superclasses

class Car: Vehicle {
    let numberOfDoors: Int
    
    init(name: String, numberOfDoors: Int){
        self.numberOfDoors = numberOfDoors
        //call des init of superclass
        // cannot call convenience inits
        super.init(name: name)
    }
    
    convenience override init(name: String) {
        // we are overriding the base class init
        self.init(name: name, numberOfDoors: 4)
    }
    
    convenience init() { //doesn't need to override becuase it isn't changing the default
        self.init(name: "Unnamed")
    }
}



// Convenience Inits Rules summarization
/*
 Every class must have a designated init
 responsible for calling superclass' designated inti
 
 2
 classes can have an number of convenience init
 can call other inits in the same class
 
 3
 conv init must ultimately call a des init
 
 
 subclasses don't necessarily need to call on the super class' convenience inits.
 
 */

// Required Initializers
// adding required to an init, all subclasses have to use it

//example
class SomeClass {
    required init() {}
}

class AnotherClass: SomeClass {
    init (test: String){}
    
    required init() {
        fatalError("init() has not been implemented")
    }
    
}


// using UIKit for example

import UIKit

class ViewController: UIViewController {
    init () {
        super.init(nibName: nil, bundle: nil)
    }
    
    required init?(coder aDecoder: NSCoder) {
        super.init(coder: aDecoder)
    }
    // this init value is for unarchiving views. but we may not want to use it. too bad! it's required.
    // either assign dummy values or something
    // if you define an init method in a protocol, when your conforming type is implemented, it is also marked as required
}