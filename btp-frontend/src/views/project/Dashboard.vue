<script>
export default {
    name: 'dashboard',
    props: ['projectId']
}
</script>

<template>
    <div class="py-4 px-3">
        <div class="row row-cols-1 row-cols-md-2 d-flex justify-content-md-between">
            <div class="col col-md-9">
                <h6 class="mb-3 fw-bold">Project summary</h6>
                <div class="row row-cols-1 row-cols-md-3">
                    <div class="col col-md-4">
                        <div class="card text-bg-success mb-3">
                            <div class="card-header bg-success border-0">
                                <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" fill="currentColor" class="bi bi-record-circle-fill" viewBox="0 0 16 16">
                                    <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-8 3a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"/>
                                </svg>
                            </div>
                            <div class="card-body my-2 my-md-4">
                                <h5 class="card-title fw-bold">0</h5>
                                <p class="card-text">Tickets open</p>
                            </div>
                        </div>
                    </div>
                    <div class="col col-md-4">
                        <div class="card text-bg-secondary mb-3">
                            <div class="card-header bg-secondary border-0">
                                <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" fill="currentColor" class="bi bi-check-square-fill" viewBox="0 0 16 16">
                                    <path d="M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2zm10.03 4.97a.75.75 0 0 1 .011 1.05l-3.992 4.99a.75.75 0 0 1-1.08.02L4.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093 3.473-4.425a.75.75 0 0 1 1.08-.022z"/>
                                </svg>
                            </div>
                            <div class="card-body my-2 my-md-4">
                                <h5 class="card-title fw-bold">0</h5>
                                <p class="card-text">Tickets closed</p>
                            </div>
                        </div>
                    </div>
                    <div class="col col-md-4">
                        <div class="card text-bg-light mb-3">
                            <div class="card-header bg-light border-0">
                                <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" fill="currentColor" class="bi bi-people-fill" viewBox="0 0 16 16">
                                    <path d="M7 14s-1 0-1-1 1-4 5-4 5 3 5 4-1 1-1 1H7Zm4-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6Zm-5.784 6A2.238 2.238 0 0 1 5 13c0-1.355.68-2.75 1.936-3.72A6.325 6.325 0 0 0 5 9c-4 0-5 3-5 4s1 1 1 1h4.216ZM4.5 8a2.5 2.5 0 1 0 0-5 2.5 2.5 0 0 0 0 5Z"/>
                                </svg>
                            </div>
                            <div class="card-body my-2 my-md-4">
                                <h5 class="card-title fw-bold">0</h5>
                                <p class="card-text">Collaborators</p>
                            </div>
                        </div>
                    </div>
                </div>
                <h6 class="my-3 fw-bold">Ticket summary</h6>
                <div class="row row-cols-1 row-cols-md-2 mb-4">
                    <div class="col col-md-4">
                        <div class="row row-cols-2 mb-4 flex-md-column">
                            <div class="col col-md-12 mb-md-4">
                                <div class="card border-0" style="background-color: #e9ecef;">
                                    <div class="card-body">
                                        Placeholder
                                    </div>
                                </div>
                            </div>
                            <div class="col col-md-12">
                                <div class="card border-0" style="background-color: #e9ecef;">
                                    <div class="card-body">
                                        Placeholder
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col col-md-8">
                        <div class="card border-0" style="background-color: #e9ecef;">
                            <div class="card-body">
                                Placeholder
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row row-cols-1 mb-3">
                    <div class="col-12">
                        <div class="card border-0 bg-light">
                            <div class="card-body">
                                Placeholder
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col col-md-3">
                <div class="mb-3">
                    <h6 class="mb-3 fw-bold">About</h6>
                </div>
                <ul class="list-group list-group-flush mb-3">
                    <a class="list-group-item ps-0">Description
                        <p class="text-muted my-1">Placeholder</p>
                    </a>
                    <a class="list-group-item ps-0">Created
                        <p class="text-muted my-1">Placeholder</p>
                    </a>
                    <a class="list-group-item ps-0">Owner
                        <p class="text-muted my-1">Placeholder</p>
                    </a>
                    <a class="list-group-item ps-0">Last updated
                        <p class="text-muted my-1">Placeholder</p>
                    </a>
                    <a class="list-group-item ps-0">Last updated by
                        <p class="text-muted my-1">Placeholder</p>
                    </a>
                </ul>
            </div>
        </div>
    </div>
</template>

<style scoped>
.list-group-item {
    font-size: 0.9rem;
}
</style>