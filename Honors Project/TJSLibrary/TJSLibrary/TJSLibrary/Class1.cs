using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TJSLibrary
{
    public class Class1
    {
    }

    /// <summary>
    /// AnimalType Enum: -1 for Unknown, then initial animals supported are Dog, Cat, Fish, Rabbit, Elephant, Cow, Horse
    /// </summary>
    public enum AnimalType { Unknown = -1, Dog, Cat, Fish, Rabbit, Elephant, Cow, Horse };

    /// <summary>
    /// AnimalGender Enum: Unknown, Female, Male, Spayed, Neutered
    /// Note: unlike AnimalType, unknown here is a valid type, by "puberty", software should force
    /// an identification. My reasoning was to make a parallel animal age to human age of 12
    /// </summary>
    public enum AnimalGender { Unknown, Female, Male, Spayed, Neutered };

    /// <summary>
    /// class Animal: 6 properties (AnimalID-int >=1004, multiple 0f 4 must be unique)
    /// Name (String)
    /// Sex (1 of 5 values, 0-> unknown can only be valid until vet forced to identify by animal type puberty: see AnimalGender)
    /// Type (unkown is not to be allowed, thus it is -1, see AnimalType for rest)
    /// Weight (double) must be >= 0.0
    /// BDay (DateTime) Birthday of animal
    /// </summary>
    /// 


    public class Animal
    {
        // class Properties, Data Members, Variables, etc.
        private int AID;       // animal's id#  -  1004 min, mult of 4
        public String Name;    // animal's name  -i don't care what you call fido, just call 
        private int Sex;       // animal's sex unkn, m, f, neut, spay-01234  0 1 2 3 4   ...0 is a valid Unknown
        private int Type;      // -1 Unknown 0-dog 1-cat 2-fish 3-rabbit, etc not allowed after default creation
        private double Weight; // weight in pounds of animal
        private DateTime BDay; // animal's birthday

// Constructors - 6-param, null, 1 - AID, 3 - AID, Name, Type, 3 - AID, Sex, Type ....others as desired

        /// <summary>
        /// Full 6 property constructor
        /// </summary>
        /// <param name="aid">int app assigned id, unique, multiple of 4, >= 1004</param>
        /// <param name="name">String no requirements</param>
        /// <param name="sex">int 1 of 5 values (0-4)</param>
        /// <param name="type">int 1 of 7 values (0-6)</param>
        /// <param name="weight">double >= 0.0</param>
        /// <param name="dt">DateTime today or older, no future dates allowed</param>
        public Animal(int aid, string name, int sex, int type, double weight, DateTime dt)
        {
            if (aid > 1003 & aid % 4 == 0)
                AID = aid;
            else
                AID = 99; //only a valid one is going in, else 99  later- throw exception

            Name = name;  // who cares what the bugegr's name is?

            Sex = (int)hlpAnimalGender(sex);  //use helper to validate

            Type = (int)hlpAnimalType(type);  //use helper to valid

            if (weight > 0.0)   //no negative weights make sense  Change to exception in 6.01
                Weight = weight;
            else
                Weight = 0.0;

            if (dt > DateTime.Now)   //only Marty McFly is born in the future  Change to exception in 6.01
                BDay = DateTime.Now;
            else
                BDay = dt;
        }

        /// <summary>
        /// Null Constructor
        /// </summary>
        public Animal() : this(99, "Here Boy", 0, -1, 0.0, DateTime.Now)  {} //C# uses : to make use a Constructor Initializer instead calling other constructors(C++, Java)

        /// <summary>
        /// Constructor when only aid is known
        /// </summary>
        /// <param name="id"></param>
        public Animal(int id) : this(id, "Here Boy", 0, -1, 0.0, DateTime.Now) {}

        /// <summary>
        /// Constructor for aid, name, and animal type
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nam"></param>
        /// <param name="typ"></param>
        public Animal(int id, string nam, int typ) : this(id, nam, 0, typ, 0.0, DateTime.Now) { } //int string int --> AID, Name, Type

        /// <summary>
        /// Constructor for aid, sex, animal type
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sx"></param>
        /// <param name="typ"></param>
        public Animal(int id, int sx, int typ) : this(id, "Here Boy", sx, typ, 0.0, DateTime.Now) { } 

        // Accessors - Getters, Setters, Updaters
//Getters

        /// <summary>
        /// getAID returns the Ainmal's ID number
        /// </summary>
        /// <returns>int value, -1 for error condition of invalid id</returns>
        public int getAID()
        { //later throw an exception if AID is 99  ....Unit 6.01
            if(AID == 99)
                return -1;
            return AID;  }

        /// <summary>
        /// getName returns animal's name, not necessary as property is public
        /// </summary>
        /// <returns>String (null if name never assigned)</returns>
        public string getName()  //not necessary, just provided for convenience
        { return Name; }

        /// <summary>
        /// getSex returns current animal state 1st of overload
        /// </summary>
        /// <param name="s">int parameter is a fake to provide unique footprint</param>
        /// <returns>Enum AnimalGender</returns>
        public AnimalGender getSex(int s) //one of 3 overloaded getters, this one returns the enum, note int parameter not used
        { return hlpAnimalGender(Sex); }

        /// <summary>
        /// getSex returns current animal state 2nd of overload
        /// </summary>
        /// <returns>int value of AnimalGender</returns>
        public int getSex()  //the other overloaded getter returning actual int value
        { return Sex; }

        /// <summary>
        /// getSex returns current animal state 3rd of overload
        /// </summary>
        /// <param name="s">string parameter is a fake to provide unique footprint</param>
        /// <returns>String value of AnimalGender</returns>
        public String getSex(string s)  // ok, we need to provid the string version too
        {
            if (Sex == 1) return "Female";
            if (Sex == 2) return "Male";
            if (Sex == 3) return "Spayed";
            if (Sex == 4) return "Neutered";
            return "Unknown";
        }

        /// <summary>
        /// getType returns animal's "species", 1st of overload
        /// </summary>
        /// <param name="s">string parameter is a fake to provide unique footprint</param>
        /// <returns>Enum AnimalType</returns>
        public AnimalType getType(int s) //one of two overloaded getters, this one returns the enum, note int parameter not used
        { return hlpAnimalType(Type); }

        /// <summary>
        /// getType returns animal's "species", 2nd of overload
        /// </summary>
        /// <returns>int Type</returns>
        public int getType()  //the other overloaded getter returning actual int value
        { return Type; }  //note this will return a "valid" -1 for unknown which user should treat as error code

        /// <summary>
        /// getType returns animal's "species", 3rd of overload
        /// </summary>
        /// <param name="s">string parameter is a fake to provide unique footprint</param>
        /// <returns>String value of animal type</returns>
        public String getType(string s)  // ok, we need to provid the string version too
        {
            if (Type == 0) return "Dog";
            if (Type == 1) return "Cat";
            if (Type == 2) return "Fish";
            if (Type == 3) return "Rabbit";
            if (Type == 4) return "Elephant";
            if (Type == 5) return "Cow";
            if (Type == 6) return "Horse";
            return "Unknown";
        }

        /// <summary>
        /// getWeight returns animals weight
        /// </summary>
        /// <returns>double positive weight value or -1.0 if error</returns>
        public double getWeight()
        {
            if (Weight > 0.0)
                return Weight;
            else
                return -1.0;
        }

        /// <summary>
        /// getBDay returns animal's birthday
        /// </summary>
        /// <returns>DateTime value</returns>
        public DateTime getBDay()
        { return BDay; }
//Updaters
        /// <summary>
        /// updType updates/changes the type of animal.
        /// </summary>
        /// <param name="t">int value when int code is known</param>
        /// <returns>int type actually assigned</returns>
        public int updType(int t)
        {
            Type = (int) hlpAnimalType(t);
            return Type;
        }

        /// <summary>
        /// updSex updates animal's sex, typically male to neutered and female to spay, or originally not known
        /// </summary>
        /// <param name="t">int value reflecting new sex value</param>
        /// <returns>returns int value actually assigned</returns>
        public int updSex(int t)
        {
            Sex = (int) hlpAnimalGender(t);
            return Sex;
        }

        /// <summary>
        /// updAid accepts an animal id, validates but does not verify uniquess, that is app's responsibility
        /// </summary>
        /// <param name="aid">int value</param>
        /// <returns>returns valid int id or -1 if invalid</returns>
        public int updAID(int aid)
        { 
            if (aid > 1003 & aid % 4 == 0)
            {
                AID = aid;
                return AID;
            }
            else
                return -1; //only a valid one is going in, else error code,   later- throw exception
        }
        
        /// <summary>
        /// updWeight takes animal's current weight compares to old weight, assigns new weight, and returns %age code for change
        /// </summary>
        /// <param name="w">double w is current weight</param>
        /// <returns>int code 0, +-1 (5% gain/loss), +-2 (10% gain/loss</returns>
        public int updWeight(double w)
            {
            int status = 0;  //within +- 5% ->0,  >+-5% change -1 +1 ,  >+- 10% change -2 +2  bad -->-99
                
                if(w<0.0) return -99;  //error weight code
                double diffPerC = (w-Weight) / Weight;  //negative loss, positive gain
                
            for(int i = 0; i <= 100; i++)
            {
                if (diffPerC > i/100) status++;
                if (diffPerC < -i/100) status--;
            }

                Weight = w;
            
                return status;
            }
        /// <summary>
        /// updName accepts a new name for record, assigns it, and returns it
        /// </summary>
        /// <param name="s">String is new name</param>
        /// <returns>returns String that was assigned</returns>
        public String updName(String s)
        {
            Name = s;
            string s1 = Name.ToUpper();
            string s2 = Name.Substring(1);
            Name = s1 + s2;
            s = s1 + s2;
            return s;
        }

        /// <summary>
        /// updBDay assigns animal's birthday after validating it is not in the future
        /// </summary>
        /// <param name="dt">DateTime data type expected for birthday</param>
        /// <returns>returns DateTime assigned</returns>
        public DateTime updBDay(DateTime dt)
        {
            if (dt > DateTime.Now)
                BDay = DateTime.Now;
            else
                BDay = dt;
            return BDay;
        }

// Helpers

        /// <summary>
        /// hlpAnimalGender returns the associtaed Enum datatype for int gender
        /// </summary>
        /// <param name="s">int value identifying gender</param>
        /// <returns>enum AnimalGender</returns>
        public AnimalGender hlpAnimalGender(int s)
        {
            if (s == 1)
                return AnimalGender.Female;
            if (s == 2)
                return AnimalGender.Male;
            if (s == 3)
                return AnimalGender.Spayed;
            if (s == 4)
                return AnimalGender.Neutered;
            return AnimalGender.Unknown;
        }

        /// <summary>
        /// hlpAnimalType returns the associtaed Enum datatype for int animal type
        /// </summary>
        /// <param name="s">int value identifying type</param>
        /// <returns>enum AnimalType</returns>
        public AnimalType hlpAnimalType(int s)
        {
            if (s == 0)
                return AnimalType.Dog;
            if (s == 1)
                return AnimalType.Cat;
            if (s == 2)
                return AnimalType.Fish;
            if (s == 3)
                return AnimalType.Rabbit;
            if (s == 4)
                return AnimalType.Elephant;
            if (s == 5)
                return AnimalType.Cow;
            if (s == 6)
                return AnimalType.Horse;
            return AnimalType.Unknown;
        }

        /// <summary>
        /// hlpGetAgeH calculates age of animal in Human years
        /// </summary>
        /// <param name="xNow">DateTim current</param>
        /// <returns>returns rounded int value of human years age</returns>
        public double hlpGetAgeH(DateTime xNow)  
        {
             DateTime curr = xNow;
             TimeSpan ts = curr - BDay;
            return ts.Days / 365.25;          //calculate human years
        }

        /// <summary>
        /// hlpGetAgeA calculates age of animal in Animal years
        /// </summary>
        /// <param name="xNow">DateTim current</param>
        /// <returns>returns rounded int value of animal years age</returns>
        public double hlpGetAgeA(DateTime xNow)  
        {
            
            DateTime curr = xNow;
            TimeSpan ts = curr - BDay;
            if (Type == 0)
                return (ts.Days / 365.25) * 7;  //calculate dog years
            if (Type == 1)
                return (ts.Days / 365.25) * 8;  //cat years
            if (Type == 2)
                return (double) ((ts.Days / 365.25) * 0.6);  //fish years
            if (Type == 3)
                return (double) ((ts.Days / 365.25) * 0.3);  //rabbit years
            return -1;
        }

        public double hlpCharge(int s)
        {
            double serviceCharge = 0;

            switch (s)
            {
                case 1: //NewPatientVisit
                    serviceCharge = 30;
                    break;
                case 2: //CheckUp
                    serviceCharge = 40;
                    break;
                case 3: //DistemperShot
                    serviceCharge = 25;
                    break;
                case 4: //RabiesShot
                    serviceCharge = 20;
                    break;
                case 5: //WormShot
                    serviceCharge = 22;
                    break;
                case 6: //Spaying
                    serviceCharge = 23;
                    break;
                case 7: //Neutering
                    serviceCharge = 28;
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }

            return serviceCharge;
        }
    }
}
