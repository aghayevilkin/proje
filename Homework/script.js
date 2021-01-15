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