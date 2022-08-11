// See https://aka.ms/new-console-template for more information
string characterName ="John";
int characterAge = 35;

Console.WriteLine("Hello, World!");
Console.WriteLine("There was once a man named " + characterName);
Console.WriteLine($"He was {characterAge} years old");
Console.WriteLine("He really liked the name John");
Console.WriteLine("But \n didn't like being 35");
// Console.ReadLine();


//Data Types
string phrase="Giraffe";
char grade='a';
int age=30;
double weight=0.89;
float money=50.50F;
decimal gpa=0.2M;
bool isMale=true;
Console.WriteLine(phrase.ToUpper());
Console.WriteLine(grade);
Console.WriteLine(age);
Console.WriteLine(weight);
Console.WriteLine(money);
Console.WriteLine(gpa);
Console.WriteLine(isMale);

//String Methods
string word="There was once a man named ";
Console.WriteLine(word.Length);
Console.WriteLine(word.Contains("There"));
Console.WriteLine(word[0]);
Console.WriteLine(word.IndexOf("was"));
Console.WriteLine(word.Substring(6,3));

//Numbers
Console.WriteLine(4+2+3);
Console.WriteLine(5/2); //output will be an int
int num = 6;
num++; //incrementing by 1
Console.WriteLine(num);

//math methods
Console.WriteLine(Math.Abs(-40));
Console.WriteLine(Math.Pow(3,2));

//write prints on the same line while writline prints in different lines
//console.readline take the input of the user and store it as a variable
Console.Write("Enter your name");
string? name2= Console.ReadLine();
Console.WriteLine("Hello " + name2);


//Converting a string to an int
int numb=Convert.ToInt32("56");
Console.WriteLine(numb + 6);


//A Calculator

Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(num1 + num2);

//madlib game

string? color,pluralNoun,celebrity;

Console.Write("Enter color: ");
color=Console.ReadLine();

Console.Write("Enter plural noun: ");
pluralNoun=Console.ReadLine();

Console.Write("Enter celebrity: ");
celebrity=Console.ReadLine();

Console.WriteLine($"Roses are {color}");
Console.WriteLine($"{pluralNoun} are blue");
Console.WriteLine($"I Love {celebrity}");


//Arrays
int[] luckyNumbers = {1,2,3,4,5,6};
Console.WriteLine(luckyNumbers[0]);  //accessing elements in an array using indexing
luckyNumbers[1]=900;
Console.WriteLine(string.Join("\n",luckyNumbers));

string[] friends= new string[5]; //5 represent the number of item the array will hold
friends[0]="Jim";
friends[1]="Neo";

//methods

// static void Main(string[] args){ //main method
// Hi();
// Console.ReadLine();
// }
Hi("Cudra",5);
Hi("Cud",6);
Hi("dra",7);
Hi("Cra",8);

static void Hi(string name,int age){
    Console.WriteLine("Hello " + name +" you are " + age + "years old");
}

Console.WriteLine(cube(2));

static int cube(int numbb){  //int is where you return anything, be it a double or arrays
    int result=numbb*numbb*numbb;
    return result;
}

bool isFemale=true;
bool isTall=true;
if(isFemale && isTall){
    Console.WriteLine("You are a tall female");
}else if(isFemale && !isTall){
    Console.WriteLine("You are a short female");
}else{
    Console.WriteLine("You are not a tall Female");
}


Console.WriteLine(GetMax(1,2,3));
static int GetMax(int num1,int num2, int num3){
    int result;
    if (num1>=num2 && num1>=num3){
        result = num1;
    }else if(num2>=num1 && num2>=num3){
        result=num2;
    }else{
        result=num3;
    }
    return result;
}


//Basic Calculator with if statement

Console.Write("Enter a number: ");
double numA=Convert.ToDouble(Console.ReadLine());

Console.Write("Enter an Operator: ");
string? op=Console.ReadLine();

Console.Write("Enter a number: ");
double numB=Convert.ToDouble(Console.ReadLine());

if(op=="+"){
    Console.WriteLine(numA + numB);
}
else if(op=="-"){
    Console.WriteLine(numA - numB);
}
else if(op=="*"){
    Console.WriteLine(numA * numB);
}
else if(op=="/"){
    Console.WriteLine(numA / numB);
}else{
    Console.WriteLine("Invalid operator");
}

//Switch Statement

Console.WriteLine(GetDay(0));
static string GetDay(int dayNum){
    string dayName;

    switch(dayNum){
        case 0:
        dayName="Sunday";
        break;

        case 1:
        dayName="Monday";
        break;

        case 2:
        dayName="Tuesday";
        break;

        case 3:
        dayName="Wednesday";
        break;

        case 4:
        dayName="Thursday";
        break;

        case 5:
        dayName="Friday";
        break;

        case 6:
        dayName="Sartuday";
        break;

        default:
        dayName="Invalid Day Number";
        break;
    }

    return dayName;
}

//While loops
int index=1;
while(index<=5){
    Console.WriteLine(index);
    index++;
}

int indexA = 6;
do{
    Console.WriteLine(indexA);
    index++;
}while(index<=5);

string secretWord="giraffe";
string? guess="";
int guessCount=0;
int guessLimit=3;
bool outOfGuesses=false;

while(guess != secretWord && !outOfGuesses){

    if(guessCount<guessLimit){
    Console.Write("Enter guess: ");
    guess=Console.ReadLine();
    guessCount++;
    }
    else{
        outOfGuesses=true;
    }
}
if(outOfGuesses){
    Console.WriteLine("You lose!");
}else{
    Console.WriteLine("You Win");
}

//for loop

int[] luckyNumber={2,3,4,5,6,7,8};
for (int i=0; i<luckyNumber.Length;i++){
    Console.WriteLine(luckyNumber[i]);
}


Console.WriteLine(GetPow(3,2));
static int GetPow(int baseNum, int powNum){
    int result = 1;

    for(int i=0;i<powNum;i++){
        result=result* baseNum;
    }
    return result;
}

//2D Arrays
int[,] numberGrid={ //one comma represents a 2d array
    {1,2},
    {3,4},
    {5,6}
};
Console.WriteLine(numberGrid[0,0]); //accessed using rows and columns

//creating an array by defining the columns and rows
int[,] myArray = new int[2,3]; //2 is a row and 3 is the number of columns

//Exception handling
// catch(Exception e){
//     Console.WriteLine(e.Message);
// }
//specifying the exception
// catch(DivideByZeroException e){
//     Console.WriteLine(e.Message);
// }
//catch formart exceptions
// catch(FormatException e){
//     Console.WriteLine(e.Message);
// }

Book book1=new Book("Harry Potter","Me",12);
Book book2=new Book("Potter Harry","You",56);
Book book3=new Book();

Console.WriteLine(book2.title);

Student student1= new Student("Jim","Software Dev",2.5);
Student student2= new Student("Plow","Software Dev",5.5);
Console.WriteLine(student1.HasHonors());

int a = 32; int b = 40;