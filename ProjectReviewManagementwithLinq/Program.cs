using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectReviewManagementwithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product review management problem statement");

            List<ProductReview> lineProductReview = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 5, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 4, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 5, Review = "Good", isLike = true }
        };

            foreach { var list in productReviewList}
            {
                Console.WriteLine("ProductID" + list.ProductID +" " + "UserId:-"+ list.UserID+ nameof+ " + "+ Rating:- +"  List.Rating  " " "Review:-" + list.Review +" ""+" "isLike:-"+ list.isLike);
            }

        }
    }
}
