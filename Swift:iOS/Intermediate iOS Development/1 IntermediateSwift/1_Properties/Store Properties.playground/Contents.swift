
// Store Properties

struct Account {
    let username: String
    let password: String
}

let someAccount = Account(username: "joelmajors", password: "neverusesimplepasswords")
someAccount.username



// Type Properties

class SomeClass{
    static func someMethod() {}
}

struct Point {
    var x: Int = 0
    var y: Int = 0
}

struct Map {
    static let origin = Point()
}

Map.origin

// Computed Properties

/*
 struct Rectangle {
    let length: Int
    let width: Int
    
    var area: Int {
        return length * width
    }
    
    
}

let r1 = Rectangle(length: 10, width: 12)
r1.area
*/

struct Size {
    var width: Int = 0
    var height: Int = 0
}

struct Rectangle {
    var origin = Point()
    var size = Size()

    //computed property for center of rectangle
    // origin and size
    // assign value to

    var center: Point {
        get {
            let centerX = origin.x + size.width/2
            let centerY = origin.y + size.height/2
        
            return Point (x: centerX, y: centerY)
        }
        
        set (centerValue) {
            origin.x = centerValue.x - size.width/2
            origin.y = centerValue.y - size.height/2
        }
    }
    
}

var rect = Rectangle()
print(rect.center)
rect.size = Size(width: 20, height: 15)
print(rect.center)

rect.center = Point(x: 10, y: 15)
print(rect.center)
print(rect.origin)




// lazy loaders
import Foundation

class ReadItLaterNetworkingClient {
    lazy var session: URLSession = URLSession(configuration: .default)
    
    // do other things... until we do that, there's nothing assigned.
    // some objects take a lot of computational power. (msdate formatter is a good example.) deferring the creation saves that power and stores that.
    
}