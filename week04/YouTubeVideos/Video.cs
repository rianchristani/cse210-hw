using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class Video{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comment = new List<Comment>();


    public Video(string title, string author, int videoLength){
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public void AddComment(Comment comment){
        _comment.Add(comment);
    }

    public void DislpayAll(){
        Console.WriteLine($"Title: {_title} || Author: {_author} || Video Length: {_videoLength} seconds\n");

        for (int i = 0; i < _comment.Count(); i++){
        Console.WriteLine($"Comment: {_comment[i]._pName} - {_comment[i]._cText}");
        }

        Console.WriteLine($"\nTotal comments on the video: {_comment.Count()}\n");
    }

    }




    