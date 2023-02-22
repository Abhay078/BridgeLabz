namespace main
{
    internal class Presence

    {
        public Presence()
        {
            string s=Console.ReadLine();
            bool b=false;
            bool c=false;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]=='a' && s[i] == 'e' && s[i] == 'p') {
                    b = true;
                }
                else if(s[i] == 'a' && s[i] == 'e' || s[i] == 'a' && s[i] == 'p' || s[i] == 'e' 
                    && s[i] == 'p' || s[i] == 'a' || s[i] == 'e' || s[i] == 'p')
                {
                    c = true;
                }
           
            }
            if (b)
            {
                Console.WriteLine("All Present");
            }
            else if(c)
            {
                Console.WriteLine("One or More Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
          
        }

    }

 }

