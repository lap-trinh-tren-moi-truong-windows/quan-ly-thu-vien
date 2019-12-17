﻿using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface IAuthorService : IService<Author>
    {
        List<Author> FindByName(string name);
    }
}
