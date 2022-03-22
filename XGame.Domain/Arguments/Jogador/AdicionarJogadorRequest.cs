﻿using XGame.Domain.ValueObject;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}