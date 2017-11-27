// QUIZ ONE

protocol ConfigurableRow {
    associatedtype Object
    func configure(with object: Object)
}

// QUIZ TWO
// In the editor I've defined a protocol, PrefixContaining, that specifies that conforming types can determine whether a value contains a prefix.
    //(I've also gone ahead and added conformance to the String type.)
//Your task is to extend the Array type and 
    //add a function that lets you filter by prefix 
        // but only in cases where the array contains types that conform to PrefixContaining. 
    //The function signature should be as follows: 
        //func filter(byPrefix prefix: String) -> [Element]

//For example, your code should return the following results
// let test = ["aa", "ba", "ca", "ab"]
// let result = test.filter(byPrefix: "a") // result = ["aa", "ab"]


protocol PrefixContaining {
    func hasPrefix(_ prefix: String) -> Bool
}

extension String: PrefixContaining {}

// Enter code below

extension Array where Element: PrefixContaining {
    func filter(byPrefix prefix: String) -> [Element] {
        var output = [Element]()
        
        for element in self {
            if element.hasPrefix(prefix) {
                output.append(element)
            }
        }
        return output
    }
}

let test = ["aa", "ba", "ca", "ab"]
let result = test.filter(byPrefix: "a")