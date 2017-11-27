/* //////////////////// */
/* //////////////////// 
 Some of the simplest rules are those that govern the naming of types. The names that we give our types provide a good deal of information about what the types do and in this video we look at several conventions
 */

/*
 Naming rules have a high level goal of naming things according to their role
 */

var someValue = 12
//is not as good as
var counter = 12

class ViewController {
    // let view: View // a better name would be
    let contentView: View
}

// Names of types, properties, variables and constants shuld read as nouns

// this is general across all coding

class NetworkResponse {
        // this should not intitiate a connection
}


// Swift Standard Library Names

/* Exceptions to names reading as nouns

 Boolean Values should read as asserts about the receiver
 
 */
let listOfNumbers = List()
listOfNumbers.isEmpty

/*
 isEmpty returns t/f
 start these kind of property names with is
 */


/* //////////////////// */
/*
 Protocols that Model Capabilities
 
 use the -able, -ible, or -ing suffixes
 
 */
Equatable
Comparable
ExpressibleByStringLiteral //note where the -ible is

/* //////////////////// 
 Guidelines for Naming Methods
 */
