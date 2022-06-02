﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Task_23.Models
{
    public class TaskDbInitializer : DropCreateDatabaseIfModelChanges<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            List<ArticleModel> a1 = new List<ArticleModel>()
            {
                new ArticleModel { Id = 1,Title = "Article #1", PublicationDate = DateTime.Now, Text = "Nullam vel fringilla nulla, eget placerat tellus. Donec ac orci massa. Phasellus ex nisl, auctor eu mauris eu, scelerisque tristique nunc. Nulla fermentum lectus a mattis finibus. Pellentesque egestas molestie justo. Phasellus facilisis metus sed ornare finibus. Nunc et porttitor lectus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Duis consequat molestie dui in vulputate.\nPellentesque convallis turpis id fermentum feugiat. Sed facilisis consequat libero quis aliquam. Aenean tincidunt sodales vestibulum. Curabitur luctus lobortis leo, vel dictum ligula ultrices eget. Duis feugiat faucibus odio nec sodales. Cras a eros ac leo eleifend mattis. Morbi et metus tempor, lacinia magna porta, dictum lacus. Integer a eros accumsan, lacinia dui eget, auctor mauris. Pellentesque interdum lorem turpis, id pulvinar ipsum gravida at.\nMorbi suscipit, erat pulvinar placerat blandit, velit odio eleifend nisi, quis cursus neque mauris a tortor. Aenean facilisis in augue non tempor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque fermentum, tellus non feugiat viverra, nisl augue auctor velit, et efficitur risus dui sit amet quam. Etiam sagittis ultricies maximus. Suspendisse faucibus scelerisque orci non ultrices. Curabitur molestie nibh ac dolor interdum sagittis. Integer nibh mi, vehicula sit amet sem ac, commodo efficitur odio. Nulla commodo fringilla sapien a tempor. Sed quis metus nulla. Nullam ipsum nisl, placerat quis dapibus ut, convallis vel ipsum.\nNulla molestie vitae neque vel suscipit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla euismod egestas metus nec facilisis. Mauris fringilla nibh erat, in consequat magna pellentesque vel. Fusce nec efficitur ligula. Maecenas finibus justo a turpis imperdiet, et blandit nunc maximus. Nullam tempus auctor turpis, consectetur faucibus purus. Praesent consectetur elit eget ornare posuere. Praesent non libero magna. Pellentesque a tempor tellus. Phasellus eget pulvinar lectus, vel lacinia felis. Donec tempus scelerisque dui, sed sagittis massa.\nFusce suscipit tellus sapien, in ornare massa sagittis et. Aliquam commodo faucibus dolor, tristique efficitur dui finibus ac. Nunc vel bibendum odio. Aenean feugiat turpis eget orci tempor, a condimentum mi ultrices. Quisque dapibus facilisis ipsum, efficitur congue mi varius sed. Fusce mauris magna, semper at posuere id, ullamcorper mollis turpis. Ut ornare elit in velit laoreet tempus vel ut ipsum. Quisque vestibulum nisi a luctus lobortis. Morbi arcu ligula, vestibulum ut tortor feugiat, maximus convallis velit. Duis ut massa scelerisque, rutrum mauris non, lobortis eros. Mauris ut ipsum velit. Donec id viverra risus, id varius nibh. Aliquam egestas massa ullamcorper, gravida lacus suscipit, tincidunt erat. Curabitur placerat eu arcu nec consectetur.\nAenean in tortor et elit sollicitudin gravida at in augue. Vestibulum pharetra hendrerit libero, vitae varius enim tempus non. Pellentesque bibendum porttitor mauris non tristique. Phasellus porttitor erat a nulla pharetra lacinia. Proin eget velit nec dolor maximus mollis. Mauris nunc odio, tincidunt in rhoncus ac, tincidunt non purus. Suspendisse accumsan mi ut ultrices vulputate.\nSuspendisse sodales lectus tellus, ac scelerisque ante gravida feugiat. Morbi et condimentum dolor. Aliquam in commodo lacus. Etiam justo enim, feugiat ultricies consequat quis, dignissim ut lorem. Aliquam ac eleifend elit. Ut id nulla id odio vulputate eleifend vitae vitae orci. Phasellus tellus felis, egestas et odio ac, accumsan dapibus erat. Donec commodo erat ut nisl egestas, cursus tempus ex venenatis. Ut sem felis, finibus sit amet orci vel, iaculis elementum lectus. Maecenas sed diam nec lorem auctor pretium. Suspendisse sed finibus neque. Etiam efficitur dui eleifend nunc scelerisque hendrerit. Phasellus a ante a nunc faucibus accumsan. Aenean nisl tortor, malesuada vel tortor ac, vulputate tincidunt arcu.\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam at tellus vel justo consectetur eleifend. Nulla facilisi. Ut auctor, nisl non porta dignissim, est lacus bibendum diam, id condimentum ligula justo ac velit. Nunc gravida fermentum leo eget suscipit. Ut interdum elementum mauris vitae consequat. Proin ac lectus ut risus placerat mattis et vel nisi. Fusce tincidunt sapien nibh, non accumsan turpis interdum at. Vestibulum et sollicitudin risus. Pellentesque tortor nunc, aliquet non purus a, maximus dictum nulla. Proin placerat congue lacus. Sed leo nisi, aliquam a faucibus vitae, facilisis vel diam.\n" },
                new ArticleModel { Id = 2,Title = "Article #2", PublicationDate = DateTime.Now, Text = "Nullam vel fringilla nulla, eget placerat tellus. Donec ac orci massa. Phasellus ex nisl, auctor eu mauris eu, scelerisque tristique nunc. Nulla fermentum lectus a mattis finibus. Pellentesque egestas molestie justo. Phasellus facilisis metus sed ornare finibus. Nunc et porttitor lectus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Duis consequat molestie dui in vulputate.\nPellentesque convallis turpis id fermentum feugiat. Sed facilisis consequat libero quis aliquam. Aenean tincidunt sodales vestibulum. Curabitur luctus lobortis leo, vel dictum ligula ultrices eget. Duis feugiat faucibus odio nec sodales. Cras a eros ac leo eleifend mattis. Morbi et metus tempor, lacinia magna porta, dictum lacus. Integer a eros accumsan, lacinia dui eget, auctor mauris. Pellentesque interdum lorem turpis, id pulvinar ipsum gravida at.\nMorbi suscipit, erat pulvinar placerat blandit, velit odio eleifend nisi, quis cursus neque mauris a tortor. Aenean facilisis in augue non tempor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque fermentum, tellus non feugiat viverra, nisl augue auctor velit, et efficitur risus dui sit amet quam. Etiam sagittis ultricies maximus. Suspendisse faucibus scelerisque orci non ultrices. Curabitur molestie nibh ac dolor interdum sagittis. Integer nibh mi, vehicula sit amet sem ac, commodo efficitur odio. Nulla commodo fringilla sapien a tempor. Sed quis metus nulla. Nullam ipsum nisl, placerat quis dapibus ut, convallis vel ipsum.\nNulla molestie vitae neque vel suscipit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla euismod egestas metus nec facilisis. Mauris fringilla nibh erat, in consequat magna pellentesque vel. Fusce nec efficitur ligula. Maecenas finibus justo a turpis imperdiet, et blandit nunc maximus. Nullam tempus auctor turpis, consectetur faucibus purus. Praesent consectetur elit eget ornare posuere. Praesent non libero magna. Pellentesque a tempor tellus. Phasellus eget pulvinar lectus, vel lacinia felis. Donec tempus scelerisque dui, sed sagittis massa.\nFusce suscipit tellus sapien, in ornare massa sagittis et. Aliquam commodo faucibus dolor, tristique efficitur dui finibus ac. Nunc vel bibendum odio. Aenean feugiat turpis eget orci tempor, a condimentum mi ultrices. Quisque dapibus facilisis ipsum, efficitur congue mi varius sed. Fusce mauris magna, semper at posuere id, ullamcorper mollis turpis. Ut ornare elit in velit laoreet tempus vel ut ipsum. Quisque vestibulum nisi a luctus lobortis. Morbi arcu ligula, vestibulum ut tortor feugiat, maximus convallis velit. Duis ut massa scelerisque, rutrum mauris non, lobortis eros. Mauris ut ipsum velit. Donec id viverra risus, id varius nibh. Aliquam egestas massa ullamcorper, gravida lacus suscipit, tincidunt erat. Curabitur placerat eu arcu nec consectetur.\nAenean in tortor et elit sollicitudin gravida at in augue. Vestibulum pharetra hendrerit libero, vitae varius enim tempus non. Pellentesque bibendum porttitor mauris non tristique. Phasellus porttitor erat a nulla pharetra lacinia. Proin eget velit nec dolor maximus mollis. Mauris nunc odio, tincidunt in rhoncus ac, tincidunt non purus. Suspendisse accumsan mi ut ultrices vulputate.\nSuspendisse sodales lectus tellus, ac scelerisque ante gravida feugiat. Morbi et condimentum dolor. Aliquam in commodo lacus. Etiam justo enim, feugiat ultricies consequat quis, dignissim ut lorem. Aliquam ac eleifend elit. Ut id nulla id odio vulputate eleifend vitae vitae orci. Phasellus tellus felis, egestas et odio ac, accumsan dapibus erat. Donec commodo erat ut nisl egestas, cursus tempus ex venenatis. Ut sem felis, finibus sit amet orci vel, iaculis elementum lectus. Maecenas sed diam nec lorem auctor pretium. Suspendisse sed finibus neque. Etiam efficitur dui eleifend nunc scelerisque hendrerit. Phasellus a ante a nunc faucibus accumsan. Aenean nisl tortor, malesuada vel tortor ac, vulputate tincidunt arcu.\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam at tellus vel justo consectetur eleifend. Nulla facilisi. Ut auctor, nisl non porta dignissim, est lacus bibendum diam, id condimentum ligula justo ac velit. Nunc gravida fermentum leo eget suscipit. Ut interdum elementum mauris vitae consequat. Proin ac lectus ut risus placerat mattis et vel nisi. Fusce tincidunt sapien nibh, non accumsan turpis interdum at. Vestibulum et sollicitudin risus. Pellentesque tortor nunc, aliquet non purus a, maximus dictum nulla. Proin placerat congue lacus. Sed leo nisi, aliquam a faucibus vitae, facilisis vel diam.\n" },
                new ArticleModel { Id = 3,Title = "Article #3", PublicationDate = DateTime.Now, Text = "Nullam vel fringilla nulla, eget placerat tellus. Donec ac orci massa. Phasellus ex nisl, auctor eu mauris eu, scelerisque tristique nunc. Nulla fermentum lectus a mattis finibus. Pellentesque egestas molestie justo. Phasellus facilisis metus sed ornare finibus. Nunc et porttitor lectus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Duis consequat molestie dui in vulputate.\nPellentesque convallis turpis id fermentum feugiat. Sed facilisis consequat libero quis aliquam. Aenean tincidunt sodales vestibulum. Curabitur luctus lobortis leo, vel dictum ligula ultrices eget. Duis feugiat faucibus odio nec sodales. Cras a eros ac leo eleifend mattis. Morbi et metus tempor, lacinia magna porta, dictum lacus. Integer a eros accumsan, lacinia dui eget, auctor mauris. Pellentesque interdum lorem turpis, id pulvinar ipsum gravida at.\nMorbi suscipit, erat pulvinar placerat blandit, velit odio eleifend nisi, quis cursus neque mauris a tortor. Aenean facilisis in augue non tempor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque fermentum, tellus non feugiat viverra, nisl augue auctor velit, et efficitur risus dui sit amet quam. Etiam sagittis ultricies maximus. Suspendisse faucibus scelerisque orci non ultrices. Curabitur molestie nibh ac dolor interdum sagittis. Integer nibh mi, vehicula sit amet sem ac, commodo efficitur odio. Nulla commodo fringilla sapien a tempor. Sed quis metus nulla. Nullam ipsum nisl, placerat quis dapibus ut, convallis vel ipsum.\nNulla molestie vitae neque vel suscipit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla euismod egestas metus nec facilisis. Mauris fringilla nibh erat, in consequat magna pellentesque vel. Fusce nec efficitur ligula. Maecenas finibus justo a turpis imperdiet, et blandit nunc maximus. Nullam tempus auctor turpis, consectetur faucibus purus. Praesent consectetur elit eget ornare posuere. Praesent non libero magna. Pellentesque a tempor tellus. Phasellus eget pulvinar lectus, vel lacinia felis. Donec tempus scelerisque dui, sed sagittis massa.\nFusce suscipit tellus sapien, in ornare massa sagittis et. Aliquam commodo faucibus dolor, tristique efficitur dui finibus ac. Nunc vel bibendum odio. Aenean feugiat turpis eget orci tempor, a condimentum mi ultrices. Quisque dapibus facilisis ipsum, efficitur congue mi varius sed. Fusce mauris magna, semper at posuere id, ullamcorper mollis turpis. Ut ornare elit in velit laoreet tempus vel ut ipsum. Quisque vestibulum nisi a luctus lobortis. Morbi arcu ligula, vestibulum ut tortor feugiat, maximus convallis velit. Duis ut massa scelerisque, rutrum mauris non, lobortis eros. Mauris ut ipsum velit. Donec id viverra risus, id varius nibh. Aliquam egestas massa ullamcorper, gravida lacus suscipit, tincidunt erat. Curabitur placerat eu arcu nec consectetur.\nAenean in tortor et elit sollicitudin gravida at in augue. Vestibulum pharetra hendrerit libero, vitae varius enim tempus non. Pellentesque bibendum porttitor mauris non tristique. Phasellus porttitor erat a nulla pharetra lacinia. Proin eget velit nec dolor maximus mollis. Mauris nunc odio, tincidunt in rhoncus ac, tincidunt non purus. Suspendisse accumsan mi ut ultrices vulputate.\nSuspendisse sodales lectus tellus, ac scelerisque ante gravida feugiat. Morbi et condimentum dolor. Aliquam in commodo lacus. Etiam justo enim, feugiat ultricies consequat quis, dignissim ut lorem. Aliquam ac eleifend elit. Ut id nulla id odio vulputate eleifend vitae vitae orci. Phasellus tellus felis, egestas et odio ac, accumsan dapibus erat. Donec commodo erat ut nisl egestas, cursus tempus ex venenatis. Ut sem felis, finibus sit amet orci vel, iaculis elementum lectus. Maecenas sed diam nec lorem auctor pretium. Suspendisse sed finibus neque. Etiam efficitur dui eleifend nunc scelerisque hendrerit. Phasellus a ante a nunc faucibus accumsan. Aenean nisl tortor, malesuada vel tortor ac, vulputate tincidunt arcu.\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam at tellus vel justo consectetur eleifend. Nulla facilisi. Ut auctor, nisl non porta dignissim, est lacus bibendum diam, id condimentum ligula justo ac velit. Nunc gravida fermentum leo eget suscipit. Ut interdum elementum mauris vitae consequat. Proin ac lectus ut risus placerat mattis et vel nisi. Fusce tincidunt sapien nibh, non accumsan turpis interdum at. Vestibulum et sollicitudin risus. Pellentesque tortor nunc, aliquet non purus a, maximus dictum nulla. Proin placerat congue lacus. Sed leo nisi, aliquam a faucibus vitae, facilisis vel diam.\n" }
            };
            context.Articles.AddRange(a1);

            List<FeedbackModel> a2 = new List<FeedbackModel>()
            {
                new FeedbackModel {Id = 1,AuthorName = "Vasyl", AuthorSurname = "M.", FeedbackDate = new DateTime(2021,4,23), FeedbackText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at urna eget dui tempus iaculis. Morbi cursus lacus non metus malesuada, quis aliquet quam auctor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean fringilla ultricies velit congue egestas. Nullam interdum scelerisque nulla. Integer tempus sit amet sem vel vehicula. Maecenas ac facilisis nulla."},
                new FeedbackModel {Id = 2,AuthorName = "Nazar", AuthorSurname = "D.", FeedbackDate = new DateTime(2021,9,13), FeedbackText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at urna eget dui tempus iaculis. Morbi cursus lacus non metus malesuada, quis aliquet quam auctor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean fringilla ultricies velit congue egestas. Nullam interdum scelerisque nulla. Integer tempus sit amet sem vel vehicula. Maecenas ac facilisis nulla."},
                new FeedbackModel {Id = 3,AuthorName = "Rostyslav", AuthorSurname = "V.", FeedbackDate = new DateTime(2021,5,12), FeedbackText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at urna eget dui tempus iaculis. Morbi cursus lacus non metus malesuada, quis aliquet quam auctor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean fringilla ultricies velit congue egestas. Nullam interdum scelerisque nulla. Integer tempus sit amet sem vel vehicula. Maecenas ac facilisis nulla."},
                new FeedbackModel {Id = 4,AuthorName = "Egor", AuthorSurname = "S.", FeedbackDate = new DateTime(2021,2,11), FeedbackText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at urna eget dui tempus iaculis. Morbi cursus lacus non metus malesuada, quis aliquet quam auctor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean fringilla ultricies velit congue egestas. Nullam interdum scelerisque nulla. Integer tempus sit amet sem vel vehicula. Maecenas ac facilisis nulla."},
                new FeedbackModel {Id = 5,AuthorName = "Ostap", AuthorSurname = "K.", FeedbackDate = new DateTime(2021,10,23), FeedbackText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at urna eget dui tempus iaculis. Morbi cursus lacus non metus malesuada, quis aliquet quam auctor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean fringilla ultricies velit congue egestas. Nullam interdum scelerisque nulla. Integer tempus sit amet sem vel vehicula. Maecenas ac facilisis nulla."},
                new FeedbackModel {Id = 6,AuthorName = "Olya", AuthorSurname = "Y.", FeedbackDate = new DateTime(2021,11,15), FeedbackText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at urna eget dui tempus iaculis. Morbi cursus lacus non metus malesuada, quis aliquet quam auctor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean fringilla ultricies velit congue egestas. Nullam interdum scelerisque nulla. Integer tempus sit amet sem vel vehicula. Maecenas ac facilisis nulla."}
            };
            context.Feedbacks.AddRange(a2);

            context.SaveChanges();
        }
    }
}