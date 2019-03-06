
(() => {
	if (!localStorage.getItem('cookieBanner')) {
		const cookieBanner = document.querySelector('.js-cookie-banner');

		if (cookieBanner === null) {
			return;
		}

		const cookieButtons = [].slice.call(cookieBanner.querySelectorAll('.js-cookie-banner-button'));

		cookieBanner.setAttribute('style', 'display:block');
		cookieButtons.forEach(button => {
			button.addEventListener('click', () => {
				localStorage.setItem('cookieBanner', 'true');
				cookieBanner.removeAttribute('style');
			});
		});
	}
})();
