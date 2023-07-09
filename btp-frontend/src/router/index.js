// third-party services
import { createRouter, createWebHistory } from 'vue-router'
import nprogress from 'nprogress';

// custom views
import Index from '../views/home/Index.vue';
import ProjectLayout from '../views/project/Layout.vue';
import Dashboard from '../views/project/Dashboard.vue';

// configures the router using vue-router 
const router = createRouter({
	history: createWebHistory(import.meta.env.BASE_URL),
	routes: [
        {
            path: '/',
            name: 'index',
            component: Index,
            meta: {
                requiresAuth: false
            }
        },
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
            path: '/project/new',
            name: 'createProject',
            component: () => import('../views/home/Create.vue')
        },
        {
            path: '/project/:projectId',
            name: 'projectLayout',
            component: ProjectLayout,
            props: true,
            children: [
                {
                    path: 'dashboard',
                    name: 'dashboard',
                    component: Dashboard,
                    meta: {
                        requiresAuth: true
                    }
                },
            ]
        }
	]
});

router.beforeEach((to, from, next) => {
    // starts the incremental progress bar when navigating between pages
    nprogress.start();

    next();

    // if (to.meta.requiresAuth == true && authenticationService.isLoggedIn() == false) {
    //     // redirect the user to the login page if they are not authenticated
    //     next({ name: 'login' });
    // } else {
    //     // user is authenticated, allow to proceed
    //     next();
    // }
});

router.afterEach(() => {
    // once the page has been loaded, remove the progress bar
    nprogress.done();
});

export default router
