﻿using Unimake.EBank.Solutions.Services.Abstractions.Response;

namespace Unimake.EBank.Solutions.Model.Pagamento
{
    /// <summary>
    /// Retorno do extrato no formato CNAB. A propriedade <see cref="FileResponseBase{TContent}.Content"/> será preenchida com o conteúdo do arquivo no formato base64
    /// </summary>
    public class ItemPagamentoCNAB : FileResponseBase<string>
    {
    }
}