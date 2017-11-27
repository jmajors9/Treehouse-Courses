/* CONVENTIONS */

/*
Boolean Methods
 need to read as assertions
  */
func isInRange(of point: Point)
// they n

/*
 Parameters

 */
//choose names that serve documentation
    // local arg name
    // at point of def, choice of name should clearly doc func
// use default values where possible to simplify function signatures
    //in objC and other langs, have method families. one takes all args and passes them along
    //default args are preferrable in Swift
let order = lastName.compare(royalFamilyName, options: [], range: nil, locale: nil)
    // this name passes empty values or nil values. reduces cognitive burden
    // keep default args at the end of methods

/*
 METHOD FAMILIES
 */
// it's ok for free functions to share the same base name if the basically perform the same func and operate in different domains
extension Shape {
    func contains(_ other: Point) -> Bool
}
extension Collection {
    func contains(_ sought: Element) -> Bool
}
// they are distinct. not a lot of room for confusion.

/*
 
 The End!
 
 a bunch of new guidelines here. 
 over the next few courses, we'll try to implement a lot of these.
  */

// could make a chart to go over the 