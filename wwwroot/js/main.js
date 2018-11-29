const $unme = document.querySelector('.unme');
const $btnMenuOpen = document.querySelector('.btnMenu_open')
const $btnMenuClose = document.querySelector('.btnMenu_close')

$btnMenuOpen.addEventListener('click', function(){
    $unme.classList.add('menu_open')
})

$btnMenuClose.addEventListener('click', function () {
    $unme.classList.remove('menu_open')
})