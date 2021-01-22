let navToggle = document.querySelector(".navbar-toggle");

navToggle.addEventListener("click", () => {
    document.querySelector(".toggle-menu").classList.toggle("active");
    document.querySelector("html").classList.toggle("block-scroll");
    document.querySelector("#content").classList.toggle("block-scroll");
    document.querySelector("#content2").classList.toggle("block-scroll");
    document.querySelector("#content3").classList.toggle("block-scroll");
    document.querySelector("#footer").classList.toggle("block-scroll");
    navToggle.parentNode.classList.toggle("container");
    navToggle.parentNode.classList.toggle("container-fluid");
});


const prevBtn = document.querySelector('.prev-btn');
const nextBtn = document.querySelector('.next-btn');
imageBox = document.querySelector('.image-box');
TextBox = document.querySelector('.text-content');


prevBtn.addEventListener('click', (e) => {
    e.preventDefault();
    slideToPrev();
    clearInterval(autoRotate, 4000);
});

nextBtn.addEventListener('click', (e) => {
    e.preventDefault();
    slideToNext();
    clearInterval(autoRotate, 4000);
});


function slideToPrev() {
    const activeImage = document.querySelector('.image.active');
    const activeText = document.querySelector('.text.active');
    activeImage.classList.remove('active');
    activeText.classList.remove('active');

    if (activeImage.previousElementSibling != null) {
        activeImage.previousElementSibling.classList.add('active');
        activeText.previousElementSibling.classList.add('active');
    }
    else {
        imageBox.lastElementChild.classList.add('active');
        TextBox.lastElementChild.classList.add('active');
    }
}

function slideToNext() {
    const activeImage = document.querySelector('.image.active');
    const activeText = document.querySelector('.text.active');
    activeImage.classList.remove('active');
    activeText.classList.remove('active');

    if (activeImage.nextElementSibling != null) {
        activeImage.nextElementSibling.classList.add('active');
        activeText.nextElementSibling.classList.add('active');
    }
    else {
        imageBox.firstElementChild.classList.add('active');
        TextBox.firstElementChild.classList.add('active');
    }
}

const autoRotate = setInterval(slideToNext, 4000);