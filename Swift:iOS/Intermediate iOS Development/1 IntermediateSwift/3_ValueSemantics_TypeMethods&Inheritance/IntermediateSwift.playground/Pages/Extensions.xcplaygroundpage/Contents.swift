///////////////////////////////
/* Extensions
 what if we want minor fucntionality on top of an existing class?
 we can use an extension to add func to an existing class, library, other stuff...
 can also extend type for which we don't have source code
 
 rules:
 can add computed properties
 cannot add store properties or property observers
 Can add new type and instance methods
 Can define nested types: new struct inside an existing
 can add convenience init.
 */

extension Int {
    //adding a computed property that is true for odd, false if not
    var isOdd: Bool {
        return self % 2 != 0
    }
}

3.isOdd
2.isOdd

/*
extension String {
    func add(value: Int) -> Int? {
        guard let convertedNumber = Int(self) else {
            return nil
        }
        return convertedNumber + value
        
    }
}

"1".add(value: 2)


*/
///////////////////////////////
/*
 Protocol Conformance Through Extensions
 
 */

import UIKit

protocol UniquelyIdentifiable {
    var uuid: Int { get }
    // now we want all our views to have uuid
}

// we're going to use composition along wth an extension to add protocol conformance to an existing type

extension UIView: UniquelyIdentifiable {
    var uuid: Int {
        return hash
    }
}
// now we have a uuid on every instance of uiview that we create

let view = UIView()
view.hash

let view2 = UIView()
view2.hash

//view is UniquelyIdentifiable comes out true

///////////////////////////////
/* PROTOCOL EXTENSIONS
 
 
 when you extend a protocol, you can provide implementations to any method or property requirements that you have defined
 
 the purpose of a protocol is to define requirements and not worry about implementation
 but there are cases where, regardless to conforming type, the imp remains the same

 when we made a random
 
 */


protocol RandomNumberGenerator {
    func random() -> Int
}

// now we can

extension RandomNumberGenerator {
    func random() -> Int {
        return Int(arc4random())
    }
}

class Generator: RandomNumberGenerator { }
// this will already conform because a default implementation has been provided in the protocol. generator can use that

let generator = Generator()
generator.random()

protocol Person {
    var firstName: String { get }
    var lastName: String { get }
    var fullName: String { get }
    
    //adding for method dispatch
    
    func greeting() -> String
    // the above line changes what gets printed. go ahead and turn it on/off
    
}

extension Person {
    var fullName: String {
        // person is aware of firstName and lastName. they cannot be nil. the compiler can guarantee that it calls on that. we can use those values
        return "\(firstName) \(lastName)"
    }
    // adding for Method Dispatch. requirements that are not specified in the original
    func greeting() -> String {
        return "Hi, my name is \(fullName)"
    }
}

struct User: Person {
    let firstName: String
    let lastName: String
    
    // adding for method dispatch
    func greeting() -> String {
        return "Hey there! Nice to meet you, my name is \(fullName)"
    }
    
    var fullName: String {
        return "\(lastName), \(firstName)"
    }
    
}

let user = User(firstName: "Joel", lastName: "Majors")
user.fullName
user.greeting() // method dispatch

/*
 Method Dispatch
 
 */

let anotherUser: Person = User(firstName: "David", lastName: "Corona")
anotherUser.greeting()
//ignores the User greeting

//adding Friend Struct

struct Friend: Person {
    let firstName: String
    let middleName: String?
    let lastName: String
    
    var fullName: String {
        guard let middleName = middleName else {
            return "\(firstName) \(lastName)"
        }
        return "\(firstName) \(middleName) \(lastName)"
    }
    func greeting() -> String {
        return "Hola, \(fullName)!"
    }
}

let someFriend = Friend(firstName: "Benedict", middleName: "J", lastName: "Jakuben")

let people = [user, anotherUser, someFriend]

for person in people {
    print(person.greeting())
}
// still each of these only print with the protocol
// you will always use the implementation defined by the protocol type

// if your objects are protocol types or conforming types.

