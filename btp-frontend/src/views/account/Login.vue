<script>
import ErrorMessage from '../../components/ErrorMessage.vue';

export default {
    name: 'login',
    components: {
        ErrorMessage
    }
}
</script>

<template>
    <div class="container-fluid container p-4">
        <div class="m-auto w-100" style="max-width: 20rem">
            <div class="d-flex flex-column justify-content-center align-items-center">
                <img src="/logo.png" height="50px" width="50px">
                <a class="link-dark text-decoration-none my-4" style="background-color: white;">
                    <span class="fs-5 fw-semibold">Log in to <span class="fw-bold" style="color: var(--btp-orange)">Bug</span><span class="fw-bold"> Tracker</span></span>
                </a>
                <ErrorMessage message="" validationErrors=""></ErrorMessage>
                <form class="card bg-light w-100" enctype="application/x-www-form-urlencoded">
                    <div class="card-body">
                        <div class="mb-3">
                            <label for="inputEmail" class="form-label">Email</label>
                            <input type="email" class="form-control" id="inputEmail">
                        </div>
                        <div class="mb-3">
                            <label for="inputPassword" class="form-label">Password</label>
                            <input type="password" class="form-control" id="inputPassword">
                        </div>
                        <div class="d-grid gap-2 my-3">
                            <button type="submit" class="btn btn-success">Login</button>
                        </div>
                    </div>
                </form>
                <div class="card my-3 w-100">
                    <div class="card-body text-center">
                        New here? <RouterLink to="/account/register">Create an account</RouterLink>
                    </div>
                </div>
                <div class="w-100 mt-3">
                <div>
                    <small class="text-muted">Want to see how the application works?</small>
                    <button class="btn btn-sm focus-ring py-1 px-2 text-decoration-none border bg-white w-100 mt-2" type="button" data-bs-toggle="collapse" data-bs-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
                        Demonstration accounts
                    </button>
                </div>
                <div class="collapse mt-2" id="collapseExample">
                    <div class="card text-start">
                        <div class="card-body">
                            <form method="post" class="mb-2">
                                <button class="btn btn-sm btn-success w-100" type="submit">
                                    Project Owner
                                </button>
                            </form>
                            <form method="post" class="mb-2">
                                <button class="btn btn-sm btn-success w-100" type="submit">
                                    Project Admin
                                </button>
                            </form>
                            <form method="post" class="mb-2">
                                <input type="hidden" readonly />
                                <input type="hidden" readonly />
                                <button class="btn btn-sm btn-success w-100" type="submit">
                                    Project Member
                                </button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
    </div>
</template>

<style scoped>
.card, .form-control, .btn, .alert {
    border-radius: 0.15rem;
    transition: none;
}
</style>