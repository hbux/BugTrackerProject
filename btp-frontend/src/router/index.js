// third-party services
import { createRouter, createWebHistory } from 'vue-router'
import nprogress from 'nprogress';

// custom views
import Index from '../views/home/Index.vue';

// configures the router using vue-router 
const router = createRouter({
	history: createWebHistory(import.meta.env.BASE_URL),
	routes: [
        {
            path: '/account/register',
            name: 'register',
            component: () => import('../views/account/Register.vue')
        },
        {
            path: '/account/login',
            name: 'login',
            component: () => import('../views/account/Login.vue')
        },
		{
			path: '/',
			name: 'index',
			component: Index,
			meta: {
				requiresAuth: false
			}
		}
	]
});

router.beforeEach((to, from, next) => {
    // starts the incremental progress bar when navigating between pages
    nprogress.start();

    if (to.meta.requiresAuth == true && authenticationService.isLoggedIn() == false) {
        // redirect the user to the login page if they are not authenticated
        next({ name: 'login' });
    } else {
        // user is authenticated, allow to proceed
        next();
    }
});

router.afterEach(() => {
    // once the page has been loaded, remove the progress bar
    nprogress.done();
});

export default router
