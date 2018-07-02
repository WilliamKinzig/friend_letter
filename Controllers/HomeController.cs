using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{

    public class HomeController : Controller
    {
        //public string Hello() { return "Hello friend!"; }
        //public string Goodbye() { return "Goodbye friend."; }
        //In order for our server to send it as usable HTML, we need to add this decorator.
        [Produces("text/html")]

        //[Route("/letter")]
        [Route("/")]
        [Route("/journal")]  // could be my_fantastic_journal if you want
        public ActionResult Letter()
        {
          return View();
        }
        // public string Letter()
        // {
        //   return
        //   "<!DOCTYPE html>" +
        //   "<html>" +
        //   "<head>" +
        //     "<title>Hello Friend!</title>" +
        //     "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
        //   "</head>" +
        //   "<body>" +
        //     "<h1>Hello From Afar</h1>" +
        //     "<p>Dear Friend,</p>" +
        //     "<p>How are you? I hope that you are having a nice weekend. I'm learning programming while in Iceland! </p>" +
        //     "<p>Friend, you would not believe how cold it is here. I should have gone to Hawaii instead.</p>" +
        //     "<p>But I like programming a lot, so I've got that going for me. </p>" +
        //     "<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>" +
        //     "<p>Cheers,</p>" +
        //     "<p>Travel Enthusiast Jane</p>" +
        //   "</body>" +
        //   "</html>";
        // }
    }
}
