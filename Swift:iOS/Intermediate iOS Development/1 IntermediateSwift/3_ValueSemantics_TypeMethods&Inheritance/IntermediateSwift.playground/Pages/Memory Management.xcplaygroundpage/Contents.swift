/* ///////////////////// */
/* /////////////////////
//Manual Retain Release
 when you write code, everything takes up space on your ram.
 if you take up too much, ios will kill your app's process
 
 MRR was required before ios 5
 programmer responsible for memory management
 had to carefully manage object ownership relationships
 Reference counting
    internal tracking of obj in memory
    could carefully control memory footprint, keeping it small
    could release an object too often.. could crash
 
 */

/* ///////////////////// 
 
 ARC Memory Management
 Automatic Reference Counting
 only applies to reference types.
 Classes are kept track of in memory via ARC
    once done, arc frees it up
 we can create as many instances as we want
    memory can be deallocated as necessary
 
 as long as there is at least one reference, arc will not deallocate
 
 called a Strong Reference
 
 */

class Food {
    let name: String
    
    init(name: String) {
        self.name = name
        print("Memory allocated for \(name)")
    }
    //de init method - indicate when the class will be deallocated
    
    deinit {
        print("\(name) is being deinitialized. Memory deallocated")
    }
}

var reference1: Food? = Food(name: "Hot Dogs")

var reference2: Food? = reference1
// that makes two strong references

reference1 = nil
//but ref2 still strong
reference2 = nil
// memory deallocated

/* ///////////////////// 
 Memory Leaks
 */
/*
class Person {
    let name: String
    var apartment: Apartment?
    
    init(name: String) {
        self.name = name
    }
    
    deinit {
        print("\(name) is being deinitialized. Memory deallocated")
    }
}

class Apartment {
    let unit: String
    var tenant: Person?
    
    init(unit: String) {
        self.unit = unit
    }
    
    deinit {
        print("Apartment \(unit) is being deinitialized. Memory deallocated")
    }
}

var person: Person? = Person(name: "Joel")
var apartment: Apartment? = Apartment(unit: "3B")


person?.apartment = apartment
apartment?.tenant = person //this seems logical. now both have strong references between each other. but that's a bad thing. won't let arc ever deallocate

person = nil
apartment = nil
*/

/* ///////////////////// 
 Weak References
 
 one that does not keep a stronghold on the instance it refers to
 does not prevent arc from deallocating
 
 */


protocol Residence {
    weak var tenant: Person? { get set } //weak can only work with a reference type
//    weak var address: Address? { get set } // would fail because we can't ref that structure because it is weak
}

class Person {
    let name: String
    weak var apartment: Apartment?
    
    init(name: String) {
        self.name = name
    }
    
    deinit {
        print("\(name) is being deinitialized. Memory deallocated")
    }
}

class Apartment: Residence {
    let unit: String
    weak var tenant: Person?
    
    init(unit: String) {
        self.unit = unit
    }
    
    deinit {
        print("Apartment \(unit) is being deinitialized. Memory deallocated")
    }
}

var person: Person? = Person(name: "Joel")
var apartment: Apartment? = Apartment(unit: "3B")

person?.apartment = apartment
apartment?.tenant = person

person = nil
apartment = nil

//all properties with weak rferences must be a variable
// have to perform the nil checks.

//going back to protocols

protocol Loan: class { //creating a class bound protocol to make sure that only classes must conform to this protocol
    var payee: Customer { get set } //potential reference cycle
}

class Customer {
    var loan: Loan? // can't add weak to this. value type. need a way to indicate that the instances we assign to this stored property are always going to be types that conform to loan but are only reference types
}