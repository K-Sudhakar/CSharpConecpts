using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger) { 
        _logger= logger; 
        }
        public void Migrate()
        {
            _logger.Log("Db Migration on");
        }
    }
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        { 
            _logger.Log("Installer on");
        }
    }
    public class Logger
    {
        public void Log(string message) {
            Console.WriteLine(message); 
        }
    }
    public class Composition
    {
        public void DoJOB()
        {
            DbMigrator objDb=new DbMigrator(new Logger());
            Installer objIns = new Installer(new Logger());
            objDb.Migrate();
            objIns.Install();

        }
    }
}
