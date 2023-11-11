const pokemonsList = document.getElementById("pokemons-list");
const loadMoreButton = document.getElementById("loadMoreButton");
const limit = 6;
const maxRecords = 151;
let offset = 0;

function loadPokemonItens(offset, limit) {
    pokeApi.getPokemons(offset, limit).then((pokemons = []) => {
        const newHtml = pokemons.map((pokemon) => `
            <li class="pokemon bg-${pokemon.type}">
                <span class="pokemon-number num-${pokemon.type}">#${pokemon.number}</span>
                <span class="pokemon-name">${pokemon.name}</span>
                <div class="detail">
                    <ol class="pokemon-types">
                        ${pokemon.types.map((type) => `<li class="type type-${type}">${type}</li>`).join('')}
                    </ol>

                    <img src="${pokemon.image}" alt="${pokemon.name}">
                </div>
            </li>
        `).join('');
        pokemonsList.innerHTML += newHtml;
    });
};

loadPokemonItens(offset, limit);

loadMoreButton.addEventListener('click', () => {
    offset += limit;

    const qtdRecordNextPage = offset + limit;

    if(qtdRecordNextPage >= maxRecords) {
        const newLimit = maxRecords - offset;
        loadPokemonItens(offset,newLimit);

        loadMoreButton.parentElement.removeChild(loadMoreButton);
    } else {
        loadPokemonItens(offset,limit);
    }
});