using System;

class Program
{
    static void Main(string[] args)
    {
        // ------ Video 1
        Video video1 = new Video("Top 10 Smartphones of 2025", "TechReview", 600);

        Comment comment1 = new Comment("Alice", "Smartphone X changed my experience with technology, simply amazing!");
        Comment comment2 = new Comment("Bob", "I still prefer Smartphone Z. I think it has better features.");
        Comment comment3 = new Comment("Charlie", "This video was decisive for me to buy Smartphone X!");
        Comment comment4 = new Comment("Ana", "Is it worth waiting for the launch of Smartphone Y?");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        // ------ Video 2
        Video video2 = new Video("How to Use the New Smartwatch X", "TechGuru", 450);

        Comment comment5 = new Comment("John", "The design of Smartwatch X is impeccable, I loved it!");
        Comment comment6 = new Comment("Beatrice", "I think it could have more customization options.");
        Comment comment7 = new Comment("Gabriel", "Finally found a smartwatch that combines style and functionality!");
        Comment comment8 = new Comment("Renata", "This video helped me a lot, but I would still like to see a comparison with other models.");

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);

        // ------ Video 3
        Video video3 = new Video("Basic Guide to Fitness Products", "FitWithEmma", 720);

        Comment comment9 = new Comment("Paul", "I started using the new thermal bottle you recommended, it's great!");
        Comment comment10 = new Comment("Fernanda", "Is it worth investing in the exercise band you mentioned?");
        Comment comment11 = new Comment("Camila", "Thanks for the tips about the yoga mat! I'm loving mine.");
        Comment comment12 = new Comment("David", "Could you explain better about using that heart rate monitor?");

        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);

        // ------ Video 4
        Video video4 = new Video("Compilation: Funny Moments With Brand Mascots", "LaughFactory", 300);

        Comment comment13 = new Comment("Alice", "I loved the part where the mascot used the new promotional backpack! So funny!");
        Comment comment14 = new Comment("Carlos", "That mascot really showcased the product in a unique way!");
        Comment comment15 = new Comment("Joanna", "This video reminded me of the advertising campaign I saw last month.");
        Comment comment16 = new Comment("Thomas", "I hope to see more mascots promoting other cool products like this one.");

        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);      
             
        
        video1.DislpayAll();
        video2.DislpayAll();
        video3.DislpayAll();
        video4.DislpayAll();

    }
}