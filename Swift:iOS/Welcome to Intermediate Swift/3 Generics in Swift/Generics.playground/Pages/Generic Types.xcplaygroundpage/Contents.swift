// Generic Types

// one way of creating integers array
//var numbers: [Int] = []

// another version of integer array creation
var numbers = Array<Int>()

// array doesn't set the type, but let's you set whenever you create


// creating arrays

let city = "Charlotte"
// street name as opt string
// we have added a ? before to make opt. under the hood
let streetName = Optional.some("123 Street")
// using the underlying type instead of using "?"
// many fund types are super flexible.

// dict of error codes where an integer value can be used as a key to look up the error
// we declare var, give explicit ty pe of int to string
//dict is also a generic type

var errorCodes = Dictionary<Int, String>()

// next, how do we make our own?

// BREAK

// Linked Lists
// Array can sometimes require a lot of "move" operations
// Linked Lists
// two types: Singly linked or Doubly Linked
// particularly useful for doing large data sets.
// all we need to do is mod refs on a few nodes

// LINKED LISTS
// key will define the data our list can contain
class LinkedListNode<Key> {
    let key: Key // constant to keep data from changing
    
    var next: LinkedListNode? // variable because things may need to be changed.
    weak var previous: LinkedListNode? // optional because previous doesn't mean anything if it's at the top of the list.
    // there's a reference cycle in the above, so we add weak to previous
    
    init(key: Key) {
        self.key = key
    }
}

// now we've modeled an individual node, let's tackle the entire list. define new class

class LinkedList<Element>: CustomStringConvertible {
    typealias Node = LinkedListNode<Element> // this satisfies the compiler
    
    private var head: Node?
    // now we have a top level node that's empty, like an empty array
    // but it's private, so now what?
    // define computed property to refer to head of node
    // we know it cannot be mutated outside directly, so...
    
    var first: Node? {
        return head
    }
    
    //what about the last/tail node? we can also maintain a permanent reference with a stored property. EASY
    // or have a computed property that goes to the end of the list and returns the last. we keep going until we hit nil. Can be computationally expensive.
    
    var last: Node? {
        if var node = head { // if let, but using a variable.
        // while loop to traverse list by inspecting "next" property. if not nil, will keep going.
            while node.next != nil {
                node = node.next!
                // when the loop finishes, the node assigned to the var is the last one. then exit loop
            }
            return node
        } else {
            return nil
        }
    }
    
    // adding appending
    func append(_ value: Element) {
        //now create a node that contains this value as data
        let new = Node(key: value) // now add this node to end of list
        // query last var we wrote
        if let lastNode = last {
            lastNode.next = new
            //now move what was previously last node to previous property on new node
            new.previous = lastNode
        } else { // if we have no last node
            head = new
        }
    }
// now is Node at Index to retrieve value from linkedlist
    
    func node(atIndex index: Int) -> Node {
        var node = head
        // now we have to do a bit of the work ourselves as our linked list doesn't have the concept of an index on its own
        //create var to keep track of which node we're on as we go through the list.
        var counter = 0
        
        while node != nil {
            // let's check if the index matches the counter
            if counter == index {
                //then we're at the node we're looking for
                return node!
            }
            // if it doesn't match, we need to go to the next node
            counter += 1
            node = node!.next
            // while loops will keep going to the next node until we have a match. But what if we never get a match?
        }
        fatalError("Index out of bounds")
    }
    
    // now insert a new node at a given index value
    
    func insert(_ value: Element, at index: Int){
        // taking an element to insert and the index position
        // first we retrieve the element at that index value
        let nodeAtIndex = node(atIndex: index)
        //now that we have the element, we need the reference of the one before this node.
        let nodeBeforeIndex = nodeAtIndex.previous
        // Now we need to rewire next and previous references
        let new = Node(key: value)
        new.previous = nodeBeforeIndex
        new.next = nodeAtIndex
        // now we reconfigure the pointers on the two nodes on either side
        
        nodeAtIndex.previous = new
        nodeBeforeIndex?.next = new
        
        // one edge case. what if node before is nil? then our new node would be head of list. let's account for that.
        if nodeBeforeIndex == nil {
            head = new
        }
        
    }

    var description: String {
        var output = "["
        var node = head
        while node != nil {
            output += "\(node!.key)"
            node = node!.next
            if node != nil { output += ", " }
        }
        return output + "]"
    }
}

let list = LinkedList<String>()
list.append("Swift")
list.append("Language")
list.insert("Programming", at: 1)
list.node(atIndex: 1).key

//LINKED LIST OPERATIONS
// let's do some appending, linking and inserting

// now we need to conform to custom string convertible and 
// want to show that a generic type works like a normal type a lot of the time.

//with generic classes you can subclass, but you can also specify a subclass

// what if 90% of the use case is link lists containing integers?
class LinkedIntegers: LinkedList<Int> {}
// now instances of LinkedIntegers always use this concrete type and we don't have to specify these parameters
let newList = LinkedIntegers()

newList.append(1)
newList.append(45)
newList.insert(76, at: 1)

