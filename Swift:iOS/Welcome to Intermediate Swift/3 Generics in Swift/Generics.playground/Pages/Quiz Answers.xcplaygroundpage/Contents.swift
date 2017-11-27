// ONE

// Write a function named duplicate with a single generic type parameter T. The function takes two arguments, item of type T, and numberOfTimes of type Int, and returns an array of type T. The function simply creates an array containing the element duplicated by the number of times specified. For example, calling duplicate(item: 1, numberOfTimes: 4) returns [1, 1, 1, 1].


func duplicate <T> (item : T,numberOfTimes: Int)-> [T]{
    var arr : [T] = [T]()
    for _ in 0...(numberOfTimes - 1){
        arr.append(item)
    }
    return arr
}

// TWO

// In the editor define a function named map with two generic type parameters, T and U. The function takes two arguments - array of type [T], and transformation of type (T) -> U. The function returns an array of type U.
//The goal of the function is to apply the transformation operation on the array passed in as argument to return a new array containing the values transformed.
//For example given the array [1,2,3,4,5] as first argument, and a square function as the transformation argument, the result should be [1, 4, 9, 16, 25].

func map<T,U> (array: [T], transformation: (T) -> U) -> [U] {
    var newArray = [U]()
    for values in array {
        newArray.append(transformation(values))
    }
    return newArray
}

// basically I don't know what I'm doing.

// In the editor, define a function, named largest, with a generic type parameter, T. The function takes an array of type T as its first argument. Give this argument an external name of in. The return type of the function is optional T.

// not my solution

func largest<T: Comparable>(in array: [T]) -> T? {
    var largest: T?
    
    if let largestNum = array.max() {
        largest = largestNum
    } else {
        return nil
    }
    
    return largest
}

// THREE: five steps

// STEP ONE

struct Queue<Element> {
    var array = [Element]()
    
// STEP TWO
    var isEmpty: Bool {
        if array.isEmpty {
            return true
        } else {
            return false
        }
    }
//STEP THREE
    var count: Int {
        return array.count
    }
//STEP FOUR
    mutating func enqueue(_ item: Element) {
        self.array.append(item)
    }
//STEP FIVE
    mutating func dequeue() -> Element? {
        if array.isEmpty == false {
            return self.array.remove(at: 0)
        } else { 
            return nil 
        }
    }   
}