using System;
using System.Collections.Generic;
using ListPrograms.Taazaa;
namespace ListPrograms.Models
{
    public class Candidates
    {
        List<CandidatesDetails> list = new List<CandidatesDetails>();
        public Candidates()
        {
            list = new List<CandidatesDetails>();
        }
        public void CandidateName(CandidatesDetails name)
        {
            list.Add(name);
        }
        public void CandidateId(CandidatesDetails id)
        {
            list.Add(id);
        }
        public void CandidateName(CandidatesDetails name)
        {
            list.Add(name);
        }
    }
}