using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.Dal
{
    public class InMemoryData : IData
    {
        List<Skill> _skillsList;

        public InMemoryData()
        {
            _skillsList = new List<Skill>()
            {
                new Skill { Id = 1, Name = "Web" },
                new Skill { Id = 2, Name = "Ui" },
                new Skill { Id = 3, Name = "Ux" },
                new Skill { Id = 4, Name = "Photoshop" }
            };
        }

        public IQueryable<ClientComment> ClientComments()
        {
            return new List<ClientComment>()
            {
                new ClientComment()
                {
                    Id = 1,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "/images/client1.png",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt"
                },
                new ClientComment()
                {
                    Id = 2,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "/images/client2.png",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt"
                },
                new ClientComment()
                {
                    Id = 3,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "/images/client3.png",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt"
                },
            }.AsQueryable();
        }

        public IQueryable<Location> Locations()
        {
            return new List<Location>()
            {
                new Location
                {
                    Id = 1,
                    Street = "1537 Flint Street",
                    City = "Tumon",
                    State = "MP",
                    Zip = "96951",
                    Phone = "670-898-2847",
                    Email = "info@domain.com"
                },
                new Location
                {
                    Id = 2,
                    Street = "1537 Flint Street",
                    City = "Tumon",
                    State = "MP",
                    Zip = "96951",
                    Phone = "670-898-2847",
                    Email = "info@domain.com"
                },
                new Location
                {
                    Id = 3,
                    Street = "1537 Flint Street",
                    City = "Tumon",
                    State = "MP",
                    Zip = "96951",
                    Phone = "670-898-2847",
                    Email = "info@domain.com"
                },
                new Location
                {
                    Id = 4,
                    Street = "1537 Flint Street",
                    City = "Tumon",
                    State = "MP",
                    Zip = "96951",
                    Phone = "670-898-2847",
                    Email = "info@domain.com"
                },
            }.AsQueryable();
        }

        public IQueryable<RecentWork> RecentWorks()
        {
            return new List<RecentWork>()
            {
                new RecentWork()
                {
                    Id = 1,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item1.png",
                    ImageUrlLarge = "/images/portfolio/full/item1.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 2,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item2.png",
                    ImageUrlLarge = "/images/portfolio/full/item2.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 3,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item3.png",
                    ImageUrlLarge = "/images/portfolio/full/item3.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 4,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item4.png",
                    ImageUrlLarge = "/images/portfolio/full/item4.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 5,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item5.png",
                    ImageUrlLarge = "/images/portfolio/full/item5.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 6,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item6.png",
                    ImageUrlLarge = "/images/portfolio/full/item6.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 7,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item7.png",
                    ImageUrlLarge = "/images/portfolio/full/item7.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
                new RecentWork()
                {
                    Id = 8,
                    Title = "Business Theme",
                    ImageUrlSmall = "/images/portfolio/recent/item8.png",
                    ImageUrlLarge = "/images/portfolio/full/item8.png",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority"
                },
            }.AsQueryable();
        }

        public IQueryable<Service> Services()
        {
            return new List<Service>()
            {
                new Service()
                {
                    Id = 1,
                    Title = "Fresh and Clean",
                    Icon = "bullhorn",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit",
                },
                new Service()
                {
                    Id = 2,
                    Title = "Retina ready",
                    Icon = "comments",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit",
                },
                new Service()
                {
                    Id = 3,
                    Title = "Easy to customize",
                    Icon = "cloud-download",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit",
                },
                new Service()
                {
                    Id = 4,
                    Title = "Adipisicing elit",
                    Icon = "leaf",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit",
                },
                new Service()
                {
                    Id = 5,
                    Title = "Sed do eiusmod",
                    Icon = "cogs",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit",
                },
                new Service()
                {
                    Id = 6,
                    Title = "Labore et dolore",
                    Icon = "heart",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit",
                },
            }.AsQueryable();
        }

        public IQueryable<TeamMemberProfile> TeamMemberProfiles()
        {
            return new List<TeamMemberProfile>()
            {
                new TeamMemberProfile()
                {
                    Id = 1,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "images/man1.jpg",
                    Skills =  _skillsList,
                    FacebookProfileUrl = "#",
                    TwitterProfileUrl = "#",
                    GooglePlusProfileUrl = "#",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable."
                },
                new TeamMemberProfile()
                {
                    Id = 2,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "images/man2.jpg",
                    Skills =  _skillsList,
                    FacebookProfileUrl = "#",
                    TwitterProfileUrl = "#",
                    GooglePlusProfileUrl = "#",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable."
                },
                new TeamMemberProfile()
                {
                    Id = 3,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "images/man3.jpg",
                    Skills =  _skillsList,
                    FacebookProfileUrl = "#",
                    TwitterProfileUrl = "#",
                    GooglePlusProfileUrl = "#",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable."
                },
                new TeamMemberProfile()
                {
                    Id = 4,
                    Name = "John Doe",
                    Role = "Director of corlate.com",
                    ImageUrl = "images/man4.jpg",
                    Skills =  _skillsList,
                    FacebookProfileUrl = "#",
                    TwitterProfileUrl = "#",
                    GooglePlusProfileUrl = "#",
                    Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable."
                },
            }.AsQueryable();
        }
    }
}