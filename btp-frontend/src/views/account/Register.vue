<script>
import SuccessMessage from '../../components/SuccessMessage.vue';
import ErrorMessage from '../../components/ErrorMessage.vue';

export default {
    name: 'register',
    components: {
        SuccessMessage,
        ErrorMessage
    }
}
</script>

<template>
    <div class="container-fluid container p-4">
        <div class="m-auto w-100" style="max-width: 26rem">
            <div class="d-flex flex-column justify-content-center align-items-center">
                <img src="/logo.png" height="50px" width="50px">
                <a class="link-dark text-decoration-none my-4" style="background-color: white;">
                    <span class="fs-5 fw-semibold">Create your <span class="fw-bold" style="color: var(--btp-orange)">Bug</span><span class="fw-bold"> Tracker</span> account</span>
                </a>
                <SuccessMessage message=""/>
                <ErrorMessage message="" validationErrors=""/>
                <form class="card bg-light w-100">
                    <div class="card-body">
                        <div class="mb-3">
                            <label for="inputusername" class="form-label">Username</label>
                            <input type="text" class="form-control" id="inputUsername">
                            <div class="form-text" id="basic-addon4">Username must be unique.</div>
                        </div>
                        <div class="mb-3">
                            <label for="inputEmail" class="form-label">Email</label>
                            <input type="email" class="form-control" id="inputEmail">
                            <div class="form-text" id="basic-addon4">Email must be unique.</div>
                        </div>
                        <div class="mb-3">
                            <label for="inputPassword" class="form-label">Password</label>
                            <input type="password" class="form-control" id="inputPassword">
                        </div>
                        <div class="mb-3">
                            <label for="inputConfirmPassword" class="form-label">Confirm Password</label>
                            <input type="password" class="form-control" id="inputConfirmPassword">
                        </div>
                        <div class="d-grid gap-2 my-3">
                            <button type="submit" class="btn btn-success">Create your account</button>
                        </div>
                    </div>
                </form>
                <div class="card mt-3 w-100">
                    <div class="card-body text-center">
                        Already have an account? <RouterLink to="/account/login">Login now!</RouterLink>
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