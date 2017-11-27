// Generics

// can speed up dev time. 
// solve simple prob. 

// swap two integer values
//func swapInts(_ a: Int, _ b: Int) {
//    let tempA = a
//    a = b
//    b = tempA
//    but this wouldn't work because a and b are values
//}

var d = 10
var e = 12

//swapInts(d,e)

// assigns 10 to a and 12 to b. we want to pass in the vars.
// with inout we're passing the address of the var itself, where the int is stored.
// assigning the value assigned to a, b, etc.

func swapInts(_ a: inout Int, _ b: inout Int) {
    let tempA = a
    a = b
    b = tempA
}

swapInts(&d,&e)

d
e

// now switch strings

var g = "joel"
var h = "majors"

//swapInts(&g, &h)

func swapString (_ a: inout String, _ b: inout String) {
    let tempA = a
    a = b
    b = tempA
}

swapString(&g, &h)

// but this is repetitive! doing the same thing with just some different types

// let's do this with any?

func swapAny (_ a: inout Any, _ b: inout Any) {
    let tempA = a
    a = b
    b = tempA
}

// but now there's no type safety.
// we have a func that creates common ops on a bunch of types. but don't want to use any. that can introduce errors.

// let's do this right
// using T for type... somehow
// This is a generic func. using a placeholder  variable for the type.
// a and b now both have to be the same.
// it's the brackets, not the actual T
func swapValues<T> (_ a: inout T, _ b: inout T) {
    let tempA = a
    a = b
    b = tempA
}

swapValues(&d, &e)
swapValues(&g, &h)

// so T gets replaced with Int or String depending. It will only work with a uniform type. can't pass int and string to the same.

// we can make our func generic over more than one type
// This takes T and U and i have no idea.
func transform<T,U> (arg: T, operation: (T) -> U) -> U {
    return operation(arg)
}

func stringToInt(_ a: String) -> Int {
    guard let value = Int(a) else { fatalError() }
    return value
}

transform(arg: "1", operation: stringToInt)

func intToString (_ a: Int) -> String {
    return String(a)
}

transform(arg: 32, operation: intToString)

// in the two things we made, we can toss in whatever we want!
// but sometimes we want generic code that has some sort of limitations
// can get complex!

// what if we want a key given a value?

func findKey<Key, Value: Equatable> (for value: Value, in dictionary: Dictionary<Key, Value>) -> Key? {
    // if this function finds a key for the value we provide, we'll return the key. otherwise, nil
    
    for (iterKey, iterValue) in dictionary {
        if iterValue == value {
            return iterKey
        }
    }
    return nil
}
// this is failing because it's not comparing types yet (?)

// so now we can place a constraint to one of the parameters (changed Value to Value: Equatable)
// create an equator as a protocol

let airportCodes = ["CDG": "Charles de Gaulle", "HKG": "Hong Kong"]

findKey(for: "Hong Kong", in: airportCodes)

//works so far...  let's make this work with all sort of types, though.

enum Snack {
    case gum
    case cookie
}

struct Item {
    let price: Int
    let quantity: Int
}

extension Item: Equatable {
    static func ==(lhs: Item, rhs: Item) -> Bool {
        return lhs.price == rhs.price && lhs.quantity == rhs.quantity
    }
}

// dictionary for modeling a sort of inventory
let inventory: [Snack: Item] = [
    .gum: Item(price: 1, quantity: 5),
    .cookie: Item(price: 2, quantity: 3)
]

// random instance
let someItem = Item(price: 2, quantity: 3)

// findKey(for: someItem, in: inventory)
// this didn't work. Item wasn't equatable. so now we're doing something with extensions to make sure things are equatable. (line 134)

// CLASS CONSTRAINTS
// unlike protocol based constraints, stand alone, class based constraints are rare.

class Shape {}

func center<T: Shape> (of shape: T) {
    print("Called")
}
// what we're saying is that T needs to be a Shape class or subclass or instance

let testShape = Shape()
center(of: testShape)

class Square: Shape {}
let testSquare = Square()
center(of: testSquare)

// class View {}
// let testView = View()
// center(of: testView)
// this fails for some reason

func centerOf(_ shape: Shape) {
    print("Center")
}
centerOf(testShape)
centerOf(testSquare)

// so why use class constraints? I don't know. he'll talk about it later, apparently.
