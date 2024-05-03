@import url('https://fonts.googleapis.com/css2?family=Roboto&family=Roboto+Mono&display=swap');

:root{
    --branco: white;
    --cor-de-fundo: #00162E;
    --fundo-senha: #00244D;
    --fundo-texto: #001E40;
    --borda: #0075FF;
    --roboto: 'Roboto', sans-serif;
    --roboto-mono: 'Roboto Mono', monospace;
}

body{
    color: var(--branco);
    background-color: var(--cor-de-fundo);
    font-family: var(--roboto);
}

.titulo-principal{
    font-family: var(--roboto-mono);
    font-size: 32px;
}

.titulo-secundario{
    font-size: 24px;
    font-weight: 400;
}
.conteudo-titulo{ 
    text-align: center;
    margin-top: 80px;
}
.conteudo-senha{
    background: var(--fundo-senha);
    padding: 24px;
    border-bottom: 6px solid var(--borda);
}
#campo-senha {
    background-color: var(--fundo-senha);
    border: none;
    color: var(--branco);
    font-family: var(--roboto-mono);
    font-size: 40px;
}
#campo-senha {
    /* Código omitido */
}

#campo-senha:focus {
    outline: none;
}
#campo-senha:focus {
    /* Código omitido */
}

.conteudo{
    max-width: 1200px;
}
.conteudo{
    max-width: 1200px;
    margin: 0 auto;
}
.conteudo-senha{
    margin-top: 80px;
    background: var(--fundo-senha);
    padding: 24px;
    border-bottom: 6px solid var(--borda);
}


