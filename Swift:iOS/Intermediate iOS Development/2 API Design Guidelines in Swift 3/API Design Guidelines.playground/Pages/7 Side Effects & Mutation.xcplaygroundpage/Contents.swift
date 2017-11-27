/* */

/*
Methods with Side Effects
SHould be named using verb phrases
 
 adding an element to an array is a method wth a side effect. It affects the state of the array, it mutates it
 */
func append(_ newElement: Element)
// this would use a verb phrase


/*
 Methods without Side Effects

 // if it has not side effects: should be read as a noun
*/
func distance(to point: Point)

// notice distance to forms a prepositional phrase. the label point would be redundant


/*
 Naming Method Pairs - Verbs
 
 */

//Mutation Version:
anArray.filter(isEven) // we need to use the imperative form
// it will filter the array in place

// Non-mutating Version:
let filteredArray = anArray.filtered(isEven)
// take the past-tense to the imperative. in the case of pairs of methods
 //calling filtered on an array leaves the orig unchanged

//another example:
someString.stripWhitespace()
let s = someString.strippingWhitespace()
//technical reason for this: nah. forget it

/*
Naming Method Pairs - Noun
 */
let union = anArray.union(with: anotherArray)
// then add form for the non-mutating version
anArray.formUnion(with: anotherArray)


/*
 ==========RECAP==============
 these two rules will suffice with most of the methods you write
 */

// If a method performs side effects - use a verb for the base name

// If a method does not perform side effects - use a noun for the base name


/*
Exceptions for Method Pairs
 whether we use a verb or noun is determined by how the method is best described
 */

//If a method is best described using a verb:
    // Use the imperative form of the verb for the Mutating Method
    // Use -ed or -in suffix for a non-mutating method
// If a method is best described using a noun
    // Use the noun form for the non-mutating method
    // Use the form prefix for the mutating method



