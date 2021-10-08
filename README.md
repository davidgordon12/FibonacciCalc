# FibonacciCalc
Easy Fibonacci Calculator

All the online fibonacci calculator code examples I have seen, lead to negative numbers once you hit about the 10th iteration through the loop. Using Int64, this solution can get up to 91.
Made this to help me solve a question in my CS class, so it was made in 5minutes during a Zoom meeting.

Once again, Console.Read() sucks, and it breaks the iteration loop, so I am using Console.ReadLine() and converting to Int32, because this code doesn't even get past the 91st iteration anyway.

If someone wants to see the bug, just replace;
            string iterations;
            int i = Convert.ToInt32(iterations = Console.ReadLine());
            
with;
            int iterations Console.Read();
            
If you know whats going on, I would love to know (To lazy to google it).
