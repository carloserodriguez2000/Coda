﻿using Coda.Models;
using System.Web.Mvc;

namespace Coda.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Home()
        {
            return View();
        }


        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //public JsonResult SendRating(string r, string s, string id, string url)
        //{
        //    int autoId = 0;
        //    Int16 thisVote = 0;
        //    Int16 sectionId = 0;
        //    Int16.TryParse(s, out sectionId);
        //    Int16.TryParse(r, out thisVote);
        //    int.TryParse(id, out autoId);

        //    if (!User.Identity.IsAuthenticated)
        //    {
        //        return Json("Not authenticated!");
        //    }

        //    if (autoId.Equals(0))
        //    {
        //        return Json("Sorry, record to vote doesn't exists");
        //    }

        //    switch (s)
        //    {
        //        case "5": // school voting
        //            // check if he has already voted
        //            var isIt = db.RateLogs.FirstOrDefault(v => v.SectionId == sectionId &&
        //                v.UserName.Equals(User.Identity.Name, StringComparison.CurrentCultureIgnoreCase) && v.VoteForId == autoId);
        //            if (isIt != null)
        //            {
        //                // keep the school voting flag to stop voting by this member
        //                HttpCookie cookie = new HttpCookie(url, "true");
        //                Response.Cookies.Add(cookie);
        //                return Json("<br />You have already rated this post, thanks !");
        //            }

        //            var sch = db.Tabulatures.FirstOrDefault(sc => sc.Id == autoId);
        //            if (sch != null)
        //            {
        //                object obj = sch.Rating;

        //                string updatedVotes = string.Empty;
        //                string[] votes = null;
        //                if (obj != null && obj.ToString().Length > 0)
        //                {
        //                    string currentVotes = obj.ToString(); // votes pattern will be 0,0,0,0,0
        //                    votes = currentVotes.Split(',');
        //                    // if proper vote data is there in the database
        //                    if (votes.Length.Equals(5))
        //                    {
        //                        // get the current number of vote count of the selected vote, always say -1 than the current vote in the array 
        //                        int currentNumberOfVote = int.Parse(votes[thisVote - 1]);
        //                        // increase 1 for this vote
        //                        currentNumberOfVote++;
        //                        // set the updated value into the selected votes
        //                        votes[thisVote - 1] = currentNumberOfVote.ToString();
        //                    }
        //                    else
        //                    {
        //                        votes = new string[] { "0", "0", "0", "0", "0" };
        //                        votes[thisVote - 1] = "1";
        //                    }
        //                }
        //                else
        //                {
        //                    votes = new string[] { "0", "0", "0", "0", "0" };
        //                    votes[thisVote - 1] = "1";
        //                }

        //                // concatenate all arrays now
        //                foreach (string ss in votes)
        //                {
        //                    updatedVotes += ss + ",";
        //                }
        //                updatedVotes = updatedVotes.Substring(0, updatedVotes.Length - 1);

        //                db.Entry(sch).State = EntityState.Modified;
        //                sch.Rating = updatedVotes;
        //                db.SaveChanges();

        //                RateLog vm = new RateLog()
        //                {
        //                    Active = true,
        //                    SectionId = Int16.Parse(s),
        //                    UserName = User.Identity.Name,
        //                    Vote = thisVote,
        //                    VoteForId = autoId
        //                };

        //                db.RateLogs.Add(vm);

        //                db.SaveChanges();

        //                // keep the school voting flag to stop voting by this member
        //                HttpCookie cookie = new HttpCookie(url, "true");
        //                Response.Cookies.Add(cookie);
        //            }
        //            break;
        //        }
        //    return Json("<br />You rated " + r + " star(s), thanks !");
        //}
        //public ActionResult Search(string searchString)
        //{
        //    var artist = from m in db.Artists
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        artist = artist.Where(s => s.Name.Contains(searchString));
        //    }

        //    return View(artist);
        //}

    }
}