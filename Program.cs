using System;

namespace HelloCS
{
    class Program
    {
        class Searchable  {
            string value ; 
            public Searchable(string val){
                this.value = val ; 
            }

            public int numOfwords() {
                return this.value.Split(' ').Length ; 
            }

            public int numOfChars(){   
                return this.value.Length ; 
            }

            public int numOfXword (string word) {
                int counter = 0 ;
                string [] result = this.value.Split(' '); 
                foreach (var item in result)
                {
                    if (item ==word){
                        counter++; 
                    }
                }
                return counter ;
            }

            public int numOfXchars (char c) {
                 int counter = 0 ;
                 foreach(var item in this.value){
                     if(c == item){
                         counter++; 
                     }
                 }
                return counter ; 
            }

            public int lastIndexOf(char c) {
                int indexOfC = -1 ;
                for(int i = 0 ; i < this.value.Length ; i++) {
                    if(this.value[i]==c){
                        indexOfC = i ; 
                    }
                }
                return indexOfC ; 
            }


            public string mostWord() { 
                
                string [] toBeChecked = this.value.Split(' ') ; 
                int counter = 0 ;
                int mostCounter = 0 ; 
                string mostString = "" ; 

                foreach (var word in toBeChecked)
                {
                    for (int i = 0 ; i < toBeChecked.Length ; i++) {
                        if(word == toBeChecked[i]){
                            counter++ ; 
                        }
                        
                    }
                    if(counter > mostCounter){
                        mostCounter = counter ; 
                        mostString = word ; 
                    }
                counter =0 ; 
                }
                
                
                return mostString ;
            }
            // swap words 
            public string SwapConsecativeWords(){
                
                string [] words = this.value.Split(' ') ;
                string swappedString = "" ; 
                
                for(int i = 0 ; i < words.Length; i+=2){
                    if(i == words.Length -1){
                    swappedString += words[i] ; 
                    break;
                    }
                    swappedString+= words[i+1] ; 
                    swappedString+=" "+ words[i] +" " ; 
                }

                return swappedString; 
            }



        
        }
        static void Main(string[] args)
        {
            Searchable mn = new Searchable("ssss") ; // Write your tests here 
            Console.WriteLine(mn.numOfwords());
            Console.WriteLine(mn.numOfChars());
            Console.WriteLine(mn.numOfXchars('s'));
            Console.WriteLine(mn.numOfXword(""));
            Console.WriteLine(mn.lastIndexOf('s'));
            Console.WriteLine(mn.mostWord()); // finds the most repeated word in a String
            Console.WriteLine(mn.SwapConsecativeWords());
           
        }
    }
}
