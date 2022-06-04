using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImdbCoreManyToMany.Models
{
    public class FavoritesController : Controller
    {
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Toggle(int movieId)
        {
            List<int> favs = GetFavList();
            bool favorited;

            if (favs.Contains(movieId))
            {
                favs.Remove(movieId);
                favorited = false;
            }
            else
            {
                favs.Add(movieId);
                favorited = true;
            }

            return Json(new { favorited });
        }

        private List<int> GetFavList()
        {
            var favs = HttpContext.Request.Cookies["favs"];
            if (string.IsNullOrEmpty(favs))
                return new List<int>();

            return favs.Split(',').Select(s => Convert.ToInt32(s)).ToList();
        }
    }
}
