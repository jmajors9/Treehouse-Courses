//below is just a transcription of what went through terminal

int[] lockCombination = new int[3];
lockCombination
{0,0,0}
int[] lockCombination = new int[3] { 10, 5, 32 };
lockCombination
{ 10, 5, 32 }
int[] lockCombination = new [] { 10, 5, 32 };
int[] lockCombination = { 10, 5, 32 };
int last = lockCombination[2];
last
32

// Jagged arrays
class Cell {
  public string Contents { get; set; }
}

Cell[][] sheet = new Cell[100][10];
// doesn't work. thinks we're retrieving position 10

Cell[][] sheet = new Cell[100][];
sheet
{null, //100times
}

sheet[0] = new Cell[10];
{
  {null, "10times"}
  null, "99times"
}

for(int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
{
  sheet[rowIndex] = new Cell[10]; //Create a row of 10 cells
  for(int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
  {
    sheet[rowIndex][colIndex] = new Cell();
  }
}
//the above is a nested loop

//typing sheet now produces 1000 Cell

retrieve
sheet[4][7]

foreach(Cell[] row in sheet)
{
  foreach(Cell cell in row)
  {
    System.Console.Write(cell);
  }
}

// make this prettier

foreach(Cell[] row in sheet)
{
  foreach(Cell cell in row)
  {
    System.Console.Write(cell);
  }
  System.Console.WriteLine();
}

//make a certain row a different length

sheet[4] = new Cell[13];

//Disadvantages of Arrays
/* 
Once we've created an array of a certain length, you cannot add any
once you want to add at the beginning or in the middle...
*/

int[] ages = { 24, 31, 56};
ages[ages.Length] = 64;
//get exception, out of range
//what if we want to add something but keep it sorted?
//the array only has room for three.
//need to create a new array and copy from original
// search for system.array 

int[] agesCopy = new int[4];
// add things at index 1
ages.CopyTo(agesCopy, 1);
agesCopy
{0, 24, 31, 56}
agesCopy[0] = 16
agesCopy
{16, 24, 31, 56}
ages = agesCopy
/* 
WAIT! what if something is already referencing this?
we would need to go back and reset the variables for all of the other references
creating and coping is highly inefficient. same problems with removing an item from an array.
get set are quick with arrays
there's a better colleciton type out there. next videos
LIST!
*/
