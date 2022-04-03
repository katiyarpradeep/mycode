using System;
using static MyTestApp.DAL.MyCustomEntity;

namespace MyTestApp.IAL
{
    public interface IMyNewAPI
    {
         MyCustomResponse GetAllData();
    }
}
