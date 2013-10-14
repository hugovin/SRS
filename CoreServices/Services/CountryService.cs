using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CoreServices.Common.DataType;
using CoreServices.DataTransferObjects;
using CoreServices.DataTransferObjects.DataMapper;
using CoreServices.Messages.Requests;
using CoreServices.Messages.Responses;
using CoreServices.Repositories.Interface;
using Data;
using NLog;

namespace CoreServices.Services
{
    public static class CountryService
    {
        public static readonly Logger log = LogManager.GetCurrentClassLogger();
        static CountryService()
        {
            if (!Initialization.Initialized)
            {
                Initialization.InitialiceMapper();
                Initialization.Initialized = true;
            }
        }

        public static CountryResponse GetAllCountries()
        {
            var response = new CountryResponse();
            var countryRepository = new CountryRepository();
            try
            {
                var listCountries = countryRepository.Query().Where(x => x.is_active == 1).ToList();
                foreach (var country in listCountries)
                {
                    countryRepository.Detach(country);
                    response.Countries.Add(AutoMapper.Mapper.Map<country, countryDto>(country));
                    
                }
            }
            catch (InvalidOperationException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (ArgumentNullException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (NullReferenceException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (OptimisticConcurrencyException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (UpdateException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            finally
            {
                countryRepository.Dispose();
            }

            return response;
        }

        public static CountryResponse AddCountry(CountryRequest request)
        {
            var response = new CountryResponse();
            var countryRepository = new CountryRepository();
            try
            {
                var newCountry = new country
                                  {
                                      country_name = request.CountryName,
                                      created_date = DateTime.Now,
                                      modified_date = DateTime.Now,
                                      modified_by = request.ModifiedBy
                                  };
                countryRepository.Add(newCountry);
                countryRepository.SaveChanges();
            }
            catch (InvalidOperationException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (ArgumentNullException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (NullReferenceException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (OptimisticConcurrencyException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            catch (UpdateException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.FAILURE;
            }
            finally
            {
                countryRepository.Dispose();
            }

            return response;
        }

    }
}
