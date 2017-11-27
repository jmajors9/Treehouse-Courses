/* //////////////////// */
 /*
 Guidelines for Naming Methods
 */
/* recap:
 Omit needless information
 Include all words needed to avoid ambiguity
 Compensate for weak type information
    it introduces room for ambiguity
 
 */


func index(_ i: Self.Index, offsetBy n: Self.IndexDistance) -> Self.Index

/* let's break the above down
 
 Base Name
    "index": name of func outside of argument list
        
 List of Parameters (or Arguments) (_ i: ...)
    arguments are given labels
    second name "offsetBy", n: is the local name within the body to refer to the argument
    you don't have to set an internal and external name
 
    you can ommit the external name by using the underscore.
        cannot ommit local name
 
    return type: Self.Index
        should read well when used, not necessarily when defined
 
 */


/* //////////////////// */

/* let's say we want to define a func that inserts an element into an array at a particular position
 
the below looks fine, but it's important to make sure it reads well.
  */

func insert(element: Element, position: Int) {}

insert(element: "a", position: 1)

//Rule #1 Omit Needless Words
/* since insert makes it obvious we're inserting an element in an array, the argument label element is redundant
 */

func insert(_ element: Element, position: Int) {}

insert( "a", position: 1)

// now we removed the redundant "element"

// RULE #2 - Avoid Ambiguity
/*
 now let's create "remove" to counter insert
 */

func remove(_ index: Int)

remove(1)
// wait, what are we removing?

func remove(at index: Int) {}

remove(at: 1)

// that's better: explains what "1" means
// really, it's case by case!

/* --- Type Information

 the fact that the type of argument is string, the other type is int... helps inform what we can keep/cut
*/

// what if we have a class called Notification? with an "observer"

func add (_ observer: AnyObject)
// more or less clear that we're adding an observer
// but calling it:

add(self)
//is super ambiguous

func add(observer: AnyObject)
add(observer: self)

// with the case of ambiguous type information, we precede each weakly tied parameter with a noun describing its role

func addObserver(_ observer: AnyObject)
addObserver(self)

// so much better!
// why do we exclude the external name and add the argument to the base name? coming soon

// what if dict type didn't exist in line array?
// let's create one: our dict always has a type of StringToAny

func update(value: Any, key: String)
// any is very weak, but String is fundamental. but also weak, as you can pass about anythign in there.
//we need a noun to make the argument clear

func updateValue(_ value: Any, key: String)

//noa a different method

func updateValue(_ value: Any, forKey key: String)

