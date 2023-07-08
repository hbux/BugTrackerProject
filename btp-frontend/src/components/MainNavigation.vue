<script>
export default {
    name: 'mainNavigation'
}
</script>

<template>
    <ul class="navbar-nav justify-content-end flex-grow-1 pe-3">
        <li class="nav-item">
            <RouterLink to="/project/new" class="main-navigation nav-link me-2">
                <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-plus-lg" viewBox="0 0 16 16">
                    <path stroke="grey" stroke-width="0.5" fill-rule="evenodd" d="M8 2a.5.5 0 0 1 .5.5v5h5a.5.5 0 0 1 0 1h-5v5a.5.5 0 0 1-1 0v-5h-5a.5.5 0 0 1 0-1h5v-5A.5.5 0 0 1 8 2Z"/>
                </svg>
            </RouterLink>
        </li>
        <li class="nav-item">
            <RouterLink to="/notifications" class="main-navigation nav-link me-2">
                <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-bell" viewBox="0 0 16 16">
                    <path stroke="grey" stroke-width="0.5" d="M8 16a2 2 0 0 0 2-2H6a2 2 0 0 0 2 2zM8 1.918l-.797.161A4.002 4.002 0 0 0 4 6c0 .628-.134 2.197-.459 3.742-.16.767-.376 1.566-.663 2.258h10.244c-.287-.692-.502-1.49-.663-2.258C12.134 8.197 12 6.628 12 6a4.002 4.002 0 0 0-3.203-3.92L8 1.917zM14.22 12c.223.447.481.801.78 1H1c.299-.199.557-.553.78-1C2.68 10.2 3 6.88 3 6c0-2.42 1.72-4.44 4.005-4.901a1 1 0 1 1 1.99 0A5.002 5.002 0 0 1 13 6c0 .88.32 4.2 1.22 6z"/>
                </svg>
            </RouterLink>
        </li>
        <li class="nav-item">
            <RouterLink to="/account/login" class="main-navigation nav-link">Login</RouterLink>
        </li>
        <li class="nav-item me-2">
            <RouterLink to="/account/register" class="main-navigation nav-link">Register</RouterLink>
        </li>
        <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle main-navigation" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                Account
            </a>
            <ul class="dropdown-menu">
                <li><a class="dropdown-item">Hello, User</a></li>
                <li><hr class="dropdown-divider"></li>
                <li><a class="dropdown-item">Logout</a></li>
            </ul>
        </li>
    </ul>
</template>

<style scoped>
.main-navigation {
    font-weight: bold;
}

.dropdown-item {
    cursor: pointer;
}

.dropdown-menu {
    border-radius: 0.15rem;
}
</style>