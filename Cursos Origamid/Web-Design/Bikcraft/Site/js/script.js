if (window.SimpleSlide) {
    new SimpleSlide ({
        slide: "slider",
        time: 5000
    });
    new SimpleSlide ({
        slide: "portf",
        time: 5000,
        nav: true
    });
}

if (window.SimpleAnime) {
    new SimpleAnime();
}
const nav = document.getElementById('menu-header');
const corpo = document.getElementById('corpo');
const fixMenu = 'menu-fixo';
const espTop = 'corpoMenu-fixo';

function animeScroll () {
    var windowTop = window.pageYOffset;
    if ((windowTop) > 200) {
        nav.classList.add(fixMenu);
        corpo.classList.add(espTop);
    }else {
        nav.classList.remove(fixMenu);
        corpo.classList.remove(espTop);
    }
}

window.addEventListener('scroll', function() {
    animeScroll();
})