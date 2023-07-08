<script>
import ProjectSidebar from '../../components/ProjectSidebar.vue';

export default {
    name: 'index',
    components: {
        ProjectSidebar
    }
}
</script>

<template>
    <div class="content">
        <ProjectSidebar></ProjectSidebar>
        <div class="secondary-content">
            <div class="p-4">
                <div class="pb-3 mb-3 border-bottom">
                    <h6 class="link-dark text-decoration-none" style="background-color: white;">
                        <span class="fw-bold" style="color: var(--btp-orange)">Bug</span><span class="fw-bold"> Tracker</span>
                    </h6>
                    <p class="text-muted m-0 pt-2">
                        An application allowing users to track progress of an ongoing project, supporting users, roles, permissions, and notifications.
                    </p>
                </div>
                <div class="py-4">
                    <h6 class="m-0 fw-bold">Project Dashboard</h6>
                    <p class="m-0 py-2">
                        A dashboard within each project that quick insights about the project progress.
                    </p>
                    <div class="row row-cols-1">
                        <img src="/Dashboard.png">
                    </div>
                </div>
                <div class="py-4">
                    <h6 class="m-0 fw-bold">Supported functionalities</h6>
                    <div class="table-responsive">
                        <table class="table text-center">
                            <thead>
                                <tr>
                                    <th style="width: 34%;"></th>
                                    <th style="width: 22%;"></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope="row" class="text-start">Inviting users to a project</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Kicking users from a project</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Roles per project</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Role permissions</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Project dashboard</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Ticket assignee's</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Notifications</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Ticket history</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Markdown support text-formatting</th>
                                    <td>In progress</td>
                                </tr>
                                <tr>
                                    <th scope="row" class="text-start">Ticket labels</th>
                                    <td>In progress</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="py-2">
                    <h6 class="m-0 fw-bold">Tickets Overview</h6>
                    <p class="m-0 py-2">
                        Browse all open tickets and closed tickets, able to filter tickets by phrase or sort tickets based on the ticket assignee, author or default sorting techniques.
                    </p>
                    <div class="row row-cols-1">
                        <img src="/Tickets.png">
                    </div>
                </div>
                <div class="py-4">
                    <h6 class="m-0 fw-bold">In-depth tickets</h6>
                    <p class="m-0 py-2">
                        View every little detail about a particular ticket, including ticket history.
                    </p>
                    <div class="row row-cols-1">
                        <img src="/Ticket.png">
                    </div>
                </div>
                <div class="py-4">
                    <h6 class="m-0 fw-bold">Important notifications</h6>
                    <p class="m-0 py-2">
                        Recieve notifications when you've been invited to a project or when a new ticket is assigned to you!
                    </p>
                    <div class="row row-cols-1">
                        <img src="/Notifications.png">
                    </div>
                </div>
                <div class="py-4">
                    <h6 class="m-0 fw-bold">Collaborators, roles and permissions</h6>
                    <p class="m-0 py-2">
                        Each project can have different users, who are assigned to different roles. Even project permissions can be customised by owners.
                    </p>
                    <div class="row row-cols-1 mb-2">
                        <img src="/Access.png">
                    </div>
                    <div class="row row-cols-1 mb-2">
                        <img src="/Roles.png">
                    </div>
                </div>
                <div class="py-4 border-top d-flex flex-column justify-content-center text-center">
                    <h4>Looking for a new <span class="fw-bold" style="color: var(--btp-orange)">Bug</span><span class="fw-bold"> Tracker</span>?</h4>
                    <div class="d-grid gap-2 pt-4 text-center">
                        <RouterLink :to="{ name: 'register' }" class="btn btn-success">Get started</RouterLink>
                        <RouterLink :to="{ name: 'login' }" class="btn focus-ring py-1 px-2 text-decoration-none border bg-white">Login</RouterLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<style scoped>
tr > th {
    font-weight: normal;
}

img {
    max-width: 980px;
}

.btn {
    border-radius: 0.15rem;
    transition: none;
}

.content {
    display: flex;
    flex-direction: column;
}

@media (min-width: 1000px) {
    .secondary-content {
        width: 100%;
    }

    .content {
		flex-direction: row;
	}
}
</style>