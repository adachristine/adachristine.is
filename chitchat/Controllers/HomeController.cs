using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using chitchat.models;

namespace chitchat.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new index_model
        {
            posts = new List<post_model>
            {
                new post_model
                {
                    create_time = DateTime.Parse("2023-04-15 13:44Z"),
                    title = "my fancy queer website",
                    index_content =
                        @"
                        <p>hi there</p>
                        <p>this is  my fancy queer website and mvc application</p>
                        <p>there's not very much here yet</p>
                        <p>there's also some fun css stuff i'm playing with</p>
                        <p>the flag background is entirely css. it was actually really easy to do</p>
                        <p>you can check back sometime and i will have something more substantial</p>
                        <p>thanks for checking my page out i really appreciate it and would love to know your feedback</p>
                        <p>send your critique via RFC-1149-compliant channels</p>
                        <p>i'm dying to hear it</p>
                        <p>bye</p>
                        <p>the views expressed herein do not represent the views of my employer or trade union</p>
                        "
                },
                new post_model
                {
                    create_time = DateTime.Parse("2023-04-15 14:24Z"),
                    title = "about me",
                    index_content =
                        @"
                        <p>hi there</p>
                        <p>my name is ada christine</p>
                        <p>i'm a queer weirdo (a queerdo, if you wish)</p>
                        <p>i write weird software in my free time and slightly more normal software professionally</p>
                        <p>i'm a full-stack developer and i work primarily service-oriented web applications with asp.net in c#<p>
                        <p>additonally i use javascript and jquery and a little bit of react</p>
                        <p>i'm working on teaching myself more design principles and how to apply them with well-structured modern html and css</p>
                        <p>i live in iceland and it's pretty cool i guess</p>
                        <p>i'm married to a wonderful woman. she has a <a href=""https://www.youtube.com/@reykjaviknewsdesk\"">youtube channel</a> that you can like and subscribe to</p>
                        <p>i'm transgender (non-binary????). you probably guessed from the color scheme and the flag background. my prounouns are she/they</p>
                        <p>you can contact me by means described in the previous post</p>
                        <p>bye</p>
                        "
                },
                new post_model
                {
                    create_time = DateTime.Parse("2023-04-15 14:26Z"),
                    title = "this is a third post",
                    index_content =
                        @"
                        <p>hi there</p>
                        <p>this is a third post to test my layout. there's nothing to see here</p>
                        <img src=""/images/une_chat.webp"">
                        <p>except this cool cat</p>
                        <p>bye</p>
                        "
                }
            }
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
