﻿using EBank.Solutions.Primitives.PIX.Request.Consulta;
using System;
using System.Threading.Tasks;
using Unimake.EBank.Solutions.Services.PIX;
using Unimake.EBank.Solutions.Tests.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace Unimake.EBank.Solutions.Tests.PIX
{
    public class PIXConsultarTest : TestBase
    {
        #region Public Constructors

        public PIXConsultarTest(ITestOutputHelper output)
            : base(output) => StartServerDebugMode();

        #endregion Public Constructors

        #region Public Methods

        [Fact]
        public async Task ConsultarE2EIdTestAsync()
        {
            try
            {
                using var scope = await CreateAuthenticatedScopeAsync();
                var service = new PIXService();
                var response = await service.GetAsync(new PIXGetRequest
                {
                    Beneficiario = BeneficiarioDefault,
                    EndToEndId = "<< END TO END ID VÁLIDO>>"
                }, scope);

                DumpAsJson(response);
            }
            catch(Exception ex)
            {
                DumpAsJson(ex);
                throw;//forward
            }
        }

        [Fact]
        public async Task ConsultarTxIdTestAsync()
        {
            try
            {
                using var scope = await CreateAuthenticatedScopeAsync();
                var service = new PIXService();
                var response = await service.GetAsync(new PIXGetRequest
                {
                    Beneficiario = BeneficiarioDefault,
                    StartDate = DateTime.Parse("2022-11-01"),
                    EndDate = DateTime.Parse("2022-11-30"),
                    TxId = "<< TXTD VÁLIDO >>"
                }, scope);

                DumpAsJson(response);
            }
            catch(Exception ex)
            {
                DumpAsJson(ex);
                throw;//forward
            }
        }

        #endregion Public Methods
    }
}