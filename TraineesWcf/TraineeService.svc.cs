using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TraineesWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TraineeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TraineeService.svc or TraineeService.svc.cs at the Solution Explorer and start debugging.
    public class TraineeService : ITraineeService
    {
        public static List<Trainees> trainees = new List<Trainees>()
        {
            new Trainees {TraineeId=1,Name="renuka",Age=21,DOB=new DateTime(1997,1,30) },
            new Trainees {TraineeId=2,Name="shishika",Age=20,DOB=new DateTime(1997,6,14) }
        };
        public List<Trainees> AddTraniee(Trainees addNewTrainee)
        {
            trainees.Add(addNewTrainee);
            return trainees;
        }
        public List<Trainees> DeleteTrainee(int deletedTraineeId)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == deletedTraineeId);
            trainees.Remove(deletingTrainee);
            return trainees;
        }
        public List<Trainees> GetTrainee()
        {
            return trainees;
        }
        public List<Trainees> UpdateTrainee(Trainees updatedTrainee)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == updatedTrainee.TraineeId);
            if (deletingTrainee == null)
                trainees.Add(updatedTrainee);
            else
            {
                trainees.Remove(deletingTrainee);
                trainees.Add(updatedTrainee);
            }
            return trainees;
            //throw new NotImplementedException();
        }
    }
}
