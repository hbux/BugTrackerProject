<script>
export default {
    name: 'projectSidebar'
}
</script>

<template>
    <div class="sidebar bg-light">
        <div class="container-fluid container">
            <div class="btp-divider d-flex justify-content-between align-items-center fw-bold border-bottom">
                Projects
                <RouterLink :to="{ name: 'createProject' }">
                    <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="black" class="bi bi-plus-lg" viewBox="0 0 16 16">
                        <path stroke="black" stroke-width="0.5" fill-rule="evenodd" d="M8 2a.5.5 0 0 1 .5.5v5h5a.5.5 0 0 1 0 1h-5v5a.5.5 0 0 1-1 0v-5h-5a.5.5 0 0 1 0-1h5v-5A.5.5 0 0 1 8 2Z"/>
                    </svg>
                </RouterLink>
            </div>
            <nav class="flex-column py-2">
                <div class="projects-not-found fst-italic d-flex justify-content-center align-items-center my-5">
                    Projects will appear here.
                </div>
                <div>
                    <div class="nav-item placeholder-glow">
                        <p class="sidebar-link nav-link  m-0">
                            <span class="placeholder col-6"></span>
                        </p>
                    </div>
                    <div class="nav-item placeholder-glow">
                        <p class="sidebar-link nav-link m-0">
                            <span class="placeholder col-8"></span>
                        </p>
                    </div>
                    <div class="nav-item placeholder-glow">
                        <p class="sidebar-link nav-link m-0">
                            <span class="placeholder col-4"></span>
                        </p>
                    </div>
                </div>
                <div class="nav-item">
                    <RouterLink :to="{ name: 'dashboard', params: { projectId: '100' } }" class="sidebar-link nav-link">hbux/Example Project #1</RouterLink>
                </div>
            </nav>
        </div>
    </div>
</template>

<style scoped>
.sidebar-link {
    padding: 0.5rem 1rem !important;
    transition: none !important;
    border-radius: 0.15rem !important;
    font-size: 0.9rem !important;
}

.sidebar-link:hover {
    background-color: rgba(151, 151, 151, 0.1);
    color: rgb(0, 0, 0);
}

.active {
    background-color: rgba(151, 151, 151, 0.1);
    color: rgb(0, 0, 0);
    font-weight: bold;
}

.active:hover {
    background-color: rgba(100, 100, 100, 0.1);
    color: rgb(0, 0, 0);
}

.btp-divider {
    padding: 1rem;
    font-size: 0.8rem;
}

.projects-not-found {
    font-size: 0.9rem;
}

.placeholder {
    border-radius: 0.15rem;
}

@media (min-width: 1000px) {
    .sidebar {
		min-height: calc(100vh - 3.5rem);
		min-width: 300px;
		border-right: 1px solid #d6d5d5;
	}
}
</style>