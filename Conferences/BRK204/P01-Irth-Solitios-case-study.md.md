# Irth Solutions case study

-Irth-Solitios-case-study.md

MADDY MONTAQUILA: Hello everybody. Happy final Build session. Are we wake? My goodness, thank you. I was worried. I know day 3 is always the day that everyone's like, "I could stay in bed a little bit longer." Thank you all for coming out and hanging out with us. We have an amazing session today,

(00:26) all things clients and Mobile Application Development with .NET MAUI. Usually, what I do in this talk is I stand up here and tell you what .NET MAUI is. We're doing something a little bit different. We have invited a
very special guest, Rod Ball, the CTO of Irth Solutions. They had been using Maui to modernize their mobile apps.

(00:43) Thank you, round of applause. They've been using Maui to modernize their app. They have a case study
coming out with all of the Microsoft stack they're using in a couple of weeks. But we thought you could come up here and tell us a little bit about what your app does and why you chose Maui. ROD BALL: Thanks, Maddy.

(01:02) Our application allows field workers to see the work that's been assigned to them. It makes it easy for
them to prioritize their work based on risk and when it is due enabling them to make their work done on time as well as do it efficiently. Our app today was first released in 2015. Today we have thousands of users and hundreds of

(01:22) companies using our application. Our app is built using Xamarin and WPF for the desktop app. It was time to modernize our application. We wanted to unify the codebase and share more code. .NET MAUI, checked all the boxes for the requirements of our application. In the video you see playing right now behind me,

(01:48) you'll see that our home screen, navigating to our summary screen, which displays the list of items have been
assigned to the user, as well as the locations of the items on the map and then navigating the details to get more
information about them. MADDY MONTAQUILA: Cool, and taking pictures is my favorite part.

(02:09) You were a very early adopter of Maui, I think you guys were some of the first customers trying to get this
into production. Maui, GA'd at Build last year. Happy Birthday, us. Thank you. What have you seen from Maui when
you started until now? ROD BALL: We started using .NET MAUI in April of last year, well

(02:30) before it was released in GA since then we've seen consistent improvement in the features as well as regular rollouts for fixes for issues. MADDY MONTAQUILA: Cool. Tell us a little bit about the features of this app and how you're actually building them, what packages and things you are using? ROD BALL: Sure.

(02:50) We're using Visual Studio on both Windows and Mac to build our apps. We're using **Esri's ArcGIS maps** SDK for mapping, we're using **Telerik** for some controls, we are using **BrowserStack** for both automated and manual testing. Then we're using **Azure** as our backend for its reliability, scalability, and security.

(03:06) MADDY MONTAQUILA: Cool, Awesome. Let's actually look at some code. You generously gave us this screenshot. We did not want to walk through your code base. That seems like a bad idea to do live. But we zoom this in. Tell us a little bit about what's going on with this Maui app here? ROD BALL: Sure. One of the things we really

(03:22) love about .NET MAUI, is being able to do development on all the platforms in one location that really simplified our dev process. We target iOS, Android, and Windows. MADDY MONTAQUILA: Cool. One of the great things that people familiar with Maui know about is our single project structure. It seems like you're taking good advantage of it?

(03:40) ROD BALL:
Yeah, we have lots of libraries, screens, and models. Only having to manage them in one project makes it a lot easier. We have 83 views and counting in our app. MADDY MONTAQUILA: That's a lot of views. ROD BALL: Even more we had taking advantage of the fonts, images, raw assets, and styling.

(03:58) Again, all from one place with saves us loads of time. We do some platform specific things. We decided to put those into platform folders to make it easier to find. MADDY MONTAQUILA: Awesome. What's coming next? I'm sure you're not done with future work. ROD BALL: Next up we'll be implementing dynamic forms rendering using **Blazor hybrid**. 

(04:15) We'll need to generate hundreds of forums on the fly. They're designed by our business users using our web application and then render them in a Blazor web view. This will be a huge improvement over downloading HTML and JavaScript and rendering them in a WebView as we do today. 

(04:31) MADDY MONTAQUILA: Cool. Where are we in the process of actually production and publishing these apps? ROD BALL: The apps are available in the store today. We're currently in the process. We're working with customers to roll these out to the field users. We've had extremely positive feedback so far and the field users are pumped (very enthusiastic or excited). 

(04:47) MADDY MONTAQUILA: Cool, awesome. If there was one thing you are going to say to a room full of potential or existing .NET MAUI developers, what would it be? ROD BALL: We really find that the new handler architecture, it makes it easy for us to implement workarounds (a method for overcoming a problem or limitation in a program or system.) and our .NET MAUI layouts.

(05:04)  MADDY MONTAQUILA: Very cool. Well, that's Rod, everybody, thank you for joining us. ROD BALL: Thank you. MADDY MONTAQUILA: Again, keep an eye on out for the Irth Solutions case study. 