/* //////////////////// */

/* //////////////////// 
 Access Levels
 most open to most closed

Open
Public
        enable code to be used 
    uiview controller: marked as open
    allows us to call that code when we call uikit
    -they function the same way
 
Internal
        let's them be used within the module, but not outside
    -default level
 
Fileprivate
    allows to restrict use of entity to within its defining source file
 
Private
    most restrictive
    entity is restricted to the enclosing declaration
    

 for simple, self contained apps, there isn't much need to declare it as greater than Internal
 
 only matters when writing frameworks or tests
 */

/* //////////////////// 
 Defining Access Levels
 
 important: cannot define an entity in terms of an entity that has a more restrictive (lower) access level
 */

private struct Degrees {
    public var value: Double
}
/* cannot define public within private
the underlying type won't be available
 
 
 the access level always goes at the beginning
 
 if you define as a private or fileprivate, the default internal will be private
 public can have private inside, but not the otherway round
 
 
 */