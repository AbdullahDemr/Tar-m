﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal : IGenericDal<Announcement>
    {
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);

    }
}
