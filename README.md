# Ashley_MockUp_Store
 Using APIs from Printful and Sandbox Chase, I want to create my own storefront. 

 05-09-2020
 Resources
 1. 20486D - Developing ASP.NET Core MVC Web Applications - Module 13 Implementing Web APIs - Lesson 3
 2. https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client -- I used the product class layout as a start for my own product class
 3. https://docs.oracle.com/javase/7/docs/api/javax/naming/directory/package-summary.html - JAVAX seemed required from one of my resources and this is what came up when I looked into it. It seems more java based, so I probably don't need this information. 
   
   The website I was looking at was the Printful API documentaion: https://www.printful.com/docs/index
   This is where it mentioned the Authorization attribute. ASP.NET seems to have the Authorize attributes. So, I need to see how they are similar or if I can use both since Visual Studio recongized and tried to correct the problem with a using statement. 
   Next Goals
   1. Finish setting up
   2. Test to see if I can recieve the information from the API

   05-11-2020
   Resources
   1. https://www.youtube.com/watch?v=3J9Cs9ybZDg (using Giphy API) More links related to this video on a-b
      a. https://developers.giphy.com/
      b. https://developers.giphy.com/docs/sdk
   2. https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-3.1 Good information on what endpoint routing is and why this is coming up as a hurdle for the green squiglies under my code. Doesn't mean I understand it! 
   3. https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.mvcoptions?view=aspnetcore-3.1 - Found out how to change the value to false to move forward. Although, this looks important if I wanted to create other pages in my website. 
            "Gets or sets a value that determines if routing should use endpoints internally, or if legacy routing logic should be used. Endpoint routing is used to match HTTP requests to MVC actions, and to generate URLs with IUrlHelper."
    It makes me wonder if I need to keep some of the other app.etcs in the Configure section. 

   Thoughts
    I am starting to understand dependency a bit more. Interfaces are useful when we just want that list of methods and properties. That way, on our actual class, the main meat of code can be changed without trying to have a mass of code to look through when you want to just test other parts of the program. Plus, I can probably use another class in part of that interface. 
    It makes me wonder what comes first: the Interface or the Class?

    Time for break: Left off at 6:52 in YT video -  https://www.youtube.com/watch?v=3J9Cs9ybZDg

  05-12-2020
  Resources
  1. Still using YT Daniel Donbavand https://www.youtube.com/watch?v=3J9Cs9ybZDg
  2. https://developers.giphy.com/docs/api/endpoint This was used to get the link for my search endpoint
  3. https://developers.giphy.com/explorer/ This is the generated seach endpoint. I like this, very useful

  Returning to where I left off yesterday. I got the models set up and then the Giphy routes and deserilizaing that json file returned.

  Next Steps
  1. Continue from video at 16:25. This next step is going to the Startup.cs to implement the library. 
  2. Run the program to see if I can bring up the giphy stuff
  3. Then apply again to the Printful API. Now keep in mind that I do not want to show the key to the end user. So that route attribute will be useful for me to remember to do. 
  
  Later
  Resources
  1. https://www.postman.com/downloads/ - Next steps using Postman to test API (I think)
  2. https://github.com/dotnet/aspnetcore/issues/9542 - the changing the option thing was not successful again. So I googled it and here we go! The program likes it so far

  Notes 
  Okay, so everything I did on 05-09-2020 needed to be commented out. I forgot I just added stuff from the book and never really went to fix it. Homepage loads up! 

  How to Test
  1. Go to Postman
  2. Load Project
  3. Get the local host link: https://localhost:[######]/
  4. Make a new tab in the Postman and enter the link, then the v1/giphy/random/{searchCritera}
  Oh, it didn't work. Well, I mean, I went to the link directly on my end and now I see that it showed a collection of all the data

  05-15-2020
  Resouces
  1. Current Project - Going to try to recreate the steps I took from the YT video to set up my Printful API. 
  2. https://www.printful.com/docs/index -- All right! Now that I set up, I want to make sure I can retrieve this information. 
  3. https://github.com/codedghost/PrintfulLib/blob/master/PrintfulLib/PrintfulLib/Helpers/HttpClientHelper.cs -- Helpful in me finding out how others used their API key. 
  4. https://github.com/codedghost/PrintfulLib -- I want to look at this more! I like the structure of how everything looks. 

  Notes
  At this time, I only got to set up a way to have the API get request work. Now, after setting this up, I want to work on displaying the information. I hope I can get to this next part successfully. 