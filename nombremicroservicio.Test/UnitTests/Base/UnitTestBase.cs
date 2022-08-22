﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace creditoautomovilistico.Test.UnitTests.Base
{
    public class UnitTestBase
    {
        public IMapper Mapper;


        public UnitTestBase()
        {
            Mapper = GetMapper();
        }

        protected virtual MapperConfigurationExpression GetMapperConfig()
        {
            List<Type> listOfTypes = new List<Type>();
            List<Assembly> listOfAssemblies = new List<Assembly>();
            string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
            string[] files = Directory.GetFiles(directoryName, "creditoautomovilistico.*.dll");
            string[] array = files;
            foreach (string path in array)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
                listOfAssemblies.Add(Assembly.Load(fileNameWithoutExtension));
            }

            if (listOfAssemblies != null)
            {
                foreach (Assembly item in listOfAssemblies)
                {
                    listOfTypes.AddRange(item.GetTypes());
                }
            }

            MapperConfigurationExpression mapperConfigurationExpression = new MapperConfigurationExpression();

            foreach (Type itemType in listOfTypes)
            {
                if (itemType.IsSubclassOf(typeof(Profile)))
                {
                    mapperConfigurationExpression.AddProfile(itemType);

                }
            }

            return mapperConfigurationExpression;
        }

        protected virtual IMapper GetMapper()
        {
            MapperConfigurationExpression mapperConfig = GetMapperConfig();
            MapperConfiguration configurationProvider = new MapperConfiguration(mapperConfig);
            return new Mapper(configurationProvider);
        }

        public TResult GetResult<TResult>(ActionResult<TResult> actionResult)
        {
            TResult typedResult;
            ObjectResult objResult;

            objResult = (ObjectResult)actionResult.Result;
            typedResult = (TResult)objResult.Value;

            return typedResult;
        }
    }
}
