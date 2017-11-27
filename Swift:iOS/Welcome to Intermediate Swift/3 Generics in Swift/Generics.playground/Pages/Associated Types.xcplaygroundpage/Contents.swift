//Associated Types
// for protocols

protocol Stack {
    //an array with limited functionality
    //the main point is the order: last in, first out
    associatedtype Element
    mutating func push(_ element: Element)
    mutating func pop()-> Element?
        // returns last element
    var top: Element? { get }
        // lets us look at the last element without popping
}

//let's go from an associated type to more concrete usage

struct IntStack: Stack {

//    now all our funcs above will take integers
    private var array = Array<Int>()
    
    mutating func push(_ element: Int) {
        array.append(element)
    }

    mutating func pop() -> Int? {
        return array.popLast()
    }

    var top: Int? {
        return array.last
    }
}

// now let's let the compiler infer the type
// we removed typealias Element = Int from line 18

// let's say we're developing an ecommerce
// need to implement cart
// need to add any item to the cart
// if we add an item twice, we need to update qty

// let's define an item protocol
protocol ShoppingItem {
    var price: Double { get }
}

//protocol HashableShoppingItem: ShoppingItem, Hashable {}

typealias HashableShoppingItem = ShoppingItem & Hashable

// items don't have to worry about how many are being purchased
// the main part of checkout type is a dictionary that holds, as keys, all the diff items buying and values for qty
struct Checkout<Item: HashableShoppingItem> {
    var cart = [Item: Int]() // any val or obj we use as key needs to conform. so we add something... Hashable.
    // now we add something that makes that only ShoppingItem conforming items are useable
    // then we made HashableShoppingItem... but that ain't gonna work. So we're doing something with &
    // though using typealias is valid, there are better solutions. not a universal solution
}

// now we'll show why it isn't universal

class Shape {}


// we need instances of shape and whatever to be hashable
// can't create a type alias that has different types in it.
// so we'll use a generic "where" clause right before the curly
struct Animator<T> where T: Hashable, T: Shape
    // or struct Animator<T: Shape> where T: Hashable
{
    
}

// Associated Types
// a protocol with an assoc type has some diff characteristics than a normal protocol

//protocol Animal {
//    associatedtype Food
//    func eat(_ food: Food)
//}
//
//struct Kibble {}
//
//class Cat: Animal {
//    func eat(_ food: Kibble) {
//        // code
//    }
//}
//
//struct DogFood {}
//
//class Dog: Animal {
//    func eat(_ food: DogFood) {
//        //
//    }
//}
//
//let cat = Cat()
//let dog = Dog()

//more or less, the above code works just fine. now let's make it completely different
// we can't put cat and dog together and make that an array of animal. sure you can do any, but then we lose the good stuff.

protocol AnimalFood {}

protocol Animal {
    associatedtype Food: AnimalFood
    func eat(_ food: Food)
}

struct Kibble: AnimalFood {}

class Cat: Animal {
    func eat(_ food: Kibble) {
        // code
    }
}

struct DogFood: AnimalFood {}

class Dog: Animal {
    func eat(_ food: DogFood) {
        //
    }
}

let cat = Cat()
let dog = Dog()

//func feed(_ animal: Animal)
//just isn't going to work

func feed<T: Animal>(_ animal: T){}
// this will work

class Wolf<FoodType: AnimalFood>: Animal {
    func eat(_ food: FoodType) {
        // code
    }
}

let wolf = Wolf<Kibble>()
let anotherWolf = Wolf<DogFood>()
// let thirdWolf = Wolf<Int>()
// that ain't right!
// but we can create a base class for food or another protocol. (created on line105)

// but if we make AnimalFood the food for every dog and cat, then we would lose some specificity. BirdFood is AnimalFood, but that's no good.

// Another 
