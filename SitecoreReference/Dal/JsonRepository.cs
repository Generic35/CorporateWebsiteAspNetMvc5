using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using System.IO;
using Newtonsoft.Json;

namespace SitecoreReference.Dal
{
    public class JsonRepository : IRepository
    {
        private const string CLIENT_COMMENTS_FILE_PATH = "~/App_Data/ClientComments.json";
        private const string TEAM_MEMBER_PROFILE_FILE_PATH = "~/App_Data/TeamMemberProfiles.json";
        private const string SERVICES_FILE_PATH = "~/App_Data/Services.json";
        private const string RECENT_WORK_FILE_PATH = "~/App_Data/RecentWork.json";
        private const string LOCATIONS_FILE_PATH = "~/App_Data/Locations.json";

        public IQueryable<ClientComment> GetAllClientComments()
        {
            var comments = new List<ClientComment>();
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath(CLIENT_COMMENTS_FILE_PATH)))
            {
                comments = JsonConvert.DeserializeObject<List<ClientComment>>(sr.ReadToEnd());
            }

            return comments.AsQueryable();
        }

        public IQueryable<Service> GetAllServices()
        {
            var services = new List<Service>();
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath(SERVICES_FILE_PATH)))
            {
                services = JsonConvert.DeserializeObject<List<Service>>(sr.ReadToEnd());
            }

            return services.AsQueryable();
        }

        public IQueryable<TeamMemberProfile> GetAllTeamMemberProfiles()
        {
            var profiles = new List<TeamMemberProfile>();
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath(TEAM_MEMBER_PROFILE_FILE_PATH)))
            {
                profiles = JsonConvert.DeserializeObject<List<TeamMemberProfile>>(sr.ReadToEnd());
            }

            return profiles.AsQueryable();
        }

        public IQueryable<RecentWork> GetAllRecentWork()
        {
            var recentWork = new List<RecentWork>();
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath(RECENT_WORK_FILE_PATH)))
            {
                recentWork = JsonConvert.DeserializeObject<List<RecentWork>>(sr.ReadToEnd());
            }

            return recentWork.AsQueryable();
        }

        public IQueryable<Location> GetAllLocations()
        {

            var locations = new List<Location>();
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath(LOCATIONS_FILE_PATH)))
            {
                locations = JsonConvert.DeserializeObject<List<Location>>(sr.ReadToEnd());
            }

            return locations.AsQueryable();
        }
    }
}