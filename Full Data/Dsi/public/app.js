const bars = document.querySelector("#bars");
const menu = document.querySelector("#menu");
bars.addEventListener("click", () => {
  if (menu.classList.contains("hidden") && window.innerWidth < 768) {
    menu.classList.remove("hidden");
    menu.classList.add(
      "flex",
      "flex-col",
      "flex-center",
      "bg-white",
      "w-full",
      "absolute",
      "top-28",
      "h-full"
    );
  } else {
    menu.classList.add("hidden");
  }
});

document.getElementById("menuicon").innerHTML =
  '<span class="cursor-pointer lg:hidden flex mr-40 pt-10"><span><img class="p-4" src="./images/union.svg" width="70" alt="" /></span><span><img class="p-4" src="./images/mail.svg" width="70" alt="" /></span><span><img class="p-4" src="./images/media.svg" width="70" alt="" /></span></span>';

window.addEventListener("resize", () => {
  if (window.innerWidth > 768) {
    menu.classList.add("hidden");
    menu.classList.remove(
      "flex",
      "flex-col",
      "flex-center",
      "bg-white",
      "w-full",
      "absolute",
      "top-28",
      "h-full"
    );
  }
});

bars.addEventListener("click", () => {
  document.querySelector("#menu").classList.toggle("active");
  document.querySelector("main").classList.toggle("block-scroll");
  document.querySelector("footer").classList.toggle("block-scroll");
});
