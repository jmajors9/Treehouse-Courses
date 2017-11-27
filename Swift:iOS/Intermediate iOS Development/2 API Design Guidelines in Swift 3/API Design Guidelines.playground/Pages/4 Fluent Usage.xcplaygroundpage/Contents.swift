/* //////////////////// */

/* //////////////////// 
 FLUENT USAGE
 In addition to the rules we defined, an important goal when writing Swift is to use fluent English to make our code extremely readable. In this video, we look at what fluent means and the pitfalls we need to avoid.
 
 the previous video was full of more guidelines than details
  */

/*
 Rule #1
 methods and functions should read as grammatical english phrases at the use site
 */

insert("a", position: 1)
// not grammatically correct english
func insert (_ element: Element, at: Int)
insert("a", at: 2)
// that's grammatical! but "at" doesn't make much sense locally

func insert (_ element: Element, at index: Int)
insert("a", at: 2)
// now it makes really good sense and swift's type info can give more info if needed


//hypothetically calling on a string literal
func find(character: String, range: Range<String.Index>) -> Int

//looks decent...
find(character: character, range: range)
//it's ok, but doesn't read well. could make more sense

func find(character: String, in range: Range<String.Index>) -> Int
find(character: character, in: range)

// we've set the type of the character arg to string... but just using string could confuse the user on what is expected. ambiguous

func findCharacter(_ character: String, in range: Range<String.Index>) -> Int

// added a noun, but still some problems

// let's change string to Character
func find(_ character: Character, in range: Range<String.Index>) -> Int
find(character, in: range)