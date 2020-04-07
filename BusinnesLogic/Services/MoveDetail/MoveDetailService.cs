using AccessData.Entities;
using AccessData.Repository.IMoveDetailRepository;
using App.Common.Classes.Base.Repositories;
using App.Common.Classes.Base.Services;
using App.Common.Classes.Constants;
using App.Common.Classes.DTO.Common;
using App.Common.Classes.Helpers;
using App.Common.Classes.Validator;
using App.Common.Resources;
using App.Common.Resources.Distributors;
using AutoMapper;
using AutoMapper.Configuration;
using Common.Classes.BussinesLogic;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinnesLogic.Services
{
    public class MoveDetailService : BaseService<MoveDetailDTO, MoveDetail>, IMoveDetailService
    {
        private IMoveDetailRepository moveDetailRepository;
        private IMapper _mapper;

        public MoveDetailService(IBaseCRUDRepository<MoveDetail> repository, App.Common.Classes.Cache.IMemoryCacheManager
            memoryCacheManager, IMapper mapper, IServiceValidator<MoveDetail> validation, Microsoft.Extensions.Configuration.IConfiguration configuration, IMoveDetailRepository moveDetailRepository)
            : base(repository, memoryCacheManager, mapper, validation, configuration)
        {

            this.moveDetailRepository = moveDetailRepository;
            _mapper = mapper;

        }

        public async Task<ResponseFilterDTO> GetMasterFilter()
        {
            var filterList = new List<FilterDTO>()
            {
             new FilterDTO() { Name = "MoveDetailId", PropertyName = "MoveDetailId", PropertyFormat = GlobalConstants.FORMAT_NUMERIC },
             new FilterDTO() { Name = "Description", PropertyName = "Description", PropertyFormat = GlobalConstants.FORMAT_STRING },
             new FilterDTO() { Name = "Code", PropertyName = "Code", PropertyFormat = GlobalConstants.FORMAT_STRING },
            };

            var responseFilter = FilterHelper.GetResponseFilter();
            responseFilter.FilterList = filterList.OrderBy(f => f.Name).ToList();

            return responseFilter;
        }


    }

    #region Validator

    public class MoveDetailResourceValidator : BaseServiceValidator<MoveDetail, DistributorResource>
    {
        IStringLocalizer<GlobalResource> _globalLocalizer;

        public MoveDetailResourceValidator(IStringLocalizer<DistributorResource> localizer,
            IStringLocalizer<GlobalResource> globalLocalizer) : base(localizer)
        {
            _globalLocalizer = globalLocalizer;

        }

        #region Insert Rules
        public override void LoadPreInsertRules()
        {


        }

        public override void LoadPostInsertRules()
        {

        }

        #endregion

        #region Update Rules

        public override void LoadPreUpdateRules()
        {
        }

        public override void LoadPostUpdateRules()
        {

        }

        #endregion

        #region Delete Rules

        public override void LoadPreDeleteRules()
        {

        }

        public override void LoadPostDeleteRules()
        {

        }

        #endregion

        #region Advanced Validations



        #endregion
    }

    #endregion
}
