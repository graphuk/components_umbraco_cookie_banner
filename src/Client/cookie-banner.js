
(() => {
	const activeClass = 'cookie-banner_active';

	if (!localStorage.getItem('cookieBanner')) {
		const cookieBanner = document.querySelector('.js-cookie-banner');

		if (cookieBanner === null) {
			return;
		}

		const cookieButtonOk = cookieBanner.querySelector('.js-cookie-banner-ok');
		const cookieButtonClose = cookieBanner.querySelector('.js-cookie-banner-close');

		cookieBanner.classList.add(activeClass);

		if (cookieButtonOk !== null) {
			cookieButtonOk.addEventListener('click', () => {
				localStorage.setItem('cookieBanner', 'true');
				cookieBanner.classList.remove(activeClass);
			});
		}

		if (cookieButtonClose !== null) {
			cookieButtonClose.addEventListener('click', () => {
				cookieBanner.classList.remove(activeClass);
			});
		}
	}
})();
